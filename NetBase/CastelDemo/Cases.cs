using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastelDemo
{
    public interface IBaseService
    {
        void SayHello();

        bool SingSong(int songId);
    }

    public class BaseService : IBaseService
    {
        public void SayHello()
        {
            Console.WriteLine("HI,BaseService!!!");
        }

        public bool SingSong(int songId)
        {
            if (songId == 1)
            {
                Console.WriteLine("小牙刷");
            }
            else if (songId == 2)
            {
                Console.WriteLine("大公鸡");
            }

            return true;
        }
    }


    public class DefualtService : IBaseService
    {
        public void SayHello()
        {
            Console.WriteLine("HI,DefualtService!!!");
        }

        public bool SingSong(int songId)
        {
            if (songId == 1)
            {
                Console.WriteLine("小牙刷DefualtService");
            }
            else if (songId == 2)
            {
                Console.WriteLine("大公鸡DefualtService");
            }

            return true;
        }
    }
}
