using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ThreadSafe
    {
 
        private  static  List<int> _staticList = null;

        private   readonly object  _lockObj = "";

        public ThreadSafe()
        {
            if (_staticList ==null)
            {
                _staticList = new List<int>();
            }
        }
        #region List
        [TestMethod]

        public void ListAddIsSafe()
        {
            List<int> intList = new List<int>();
            var result = Parallel.ForEach(Enumerable.Range(1, 10000), (val) =>
            {
                intList.Add(val);
            });
            if (result.IsCompleted)
            {
                Console.WriteLine("intList.Count():" + intList.Count);
            }
        }
        [TestMethod]
        public void ListReadIsSafe()
        {
            List<int> intList = new List<int>();
            for (int i = 0; i < 10000; i++)
                intList.Add(i);
            int counter = 0;


            //Task.Factory.StartNew(() =>
            //{
            //    intList.ForEach(_ => { counter++; });

            //    Console.WriteLine("intList.readcount:" + counter);
            //});

            Parallel.ForEach(intList, val =>
            {
                counter++;
                //Console.WriteLine("intList.value:" + val);
            });

            Console.WriteLine("intList.readcount:" + counter);
        }
        #endregion

        [TestMethod]
        public void StaicListIsSafe()
        {

            var result = Parallel.ForEach(Enumerable.Range(1, 10000), (val) =>
            {
                    _staticList.Add(val);
            });
            if (result.IsCompleted)
            {
                Console.WriteLine("staticList.Count():" + _staticList.Count);
            }
        }
 
        [TestMethod]
        public void ConcurrentListIsSafe()
        {

            var result = Parallel.ForEach(Enumerable.Range(1, 10000), (val) =>
            {

                lock (_lockObj)
                {
                    _staticList.Add(val);
                }

            });
            if (result.IsCompleted)
            {
                Console.WriteLine("staticList.Count():" + _staticList.Count);
            }
        }

        /// <summary>
        /// 表示可由多个线程同时访问的键/值对的线程安全集合。
        /// .NET Framework 4.0 及以上。
        /// </summary>
        [TestMethod]
        public void ConcurrentDictionaryTest()
        {

            ConcurrentDictionary<int, int> cdic = new ConcurrentDictionary<int, int>();

            CodeTimer.Time("ConcurrentDictionaryTest",1, () =>
            {

                var result = Parallel.ForEach(Enumerable.Range(1, 10000000), (val) =>
                {
                    cdic.GetOrAdd(val, val * new Random(10000).Next());
                });
                if (result.IsCompleted)
                {
                    Console.WriteLine("ConcurrentDictionary.Count():" + cdic.Count);
                }
            },true);

        
        }



    }
}
