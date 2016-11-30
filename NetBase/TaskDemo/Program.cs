using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{

    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //任务的取消
            CancellationTask();

            TaskSchedulerTask();
            //创建父子任务和任务工厂的使用
            TaskFactoryApply();
            ParentChildTask();
            //使用ContinueWith方法在任务完成时启动一个新任务
            TaskContinueWith();
            //使用Task类创建并执行简单任务
            //demo1();
            //等待任务的完成并获取返回值
            //TaskWait();

            Console.Read();
        }
        /// <summary>
        /// 使用Task类创建并执行简单任务
        /// </summary>
        public static void demo1()
        {
            Console.WriteLine("主线程执行业务处理.");
            //创建任务
            Task task = new Task(() =>
            {
                Console.WriteLine("使用System.Threading.Tasks.Task执行异步操作.threadid:{0}", Thread.CurrentThread.ManagedThreadId.ToString());
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($" i={i}.threadid:{Thread.CurrentThread.ManagedThreadId.ToString()}");
                }
            });
            //启动任务,并安排到当前任务队列线程中执行任务(System.Threading.Tasks.TaskScheduler)
            task.Start();
            Console.WriteLine("主线程执行其他处理");
            //主线程挂起1000毫秒，等待任务的完成。
            Thread.Sleep(1000);
        }

        /// <summary>
        /// 等待任务的完成并获取返回值
        /// </summary>
        static void TaskWait()
        {
            //创建任务
            Task<int> task = new Task<int>(() =>
            {
                int sum = 0;
                Console.WriteLine("使用Task执行异步操作.threadid:{0}", Thread.CurrentThread.ManagedThreadId.ToString());
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($" i={i}.threadid:{Thread.CurrentThread.ManagedThreadId.ToString()}");
                    sum += i;
                }
                return sum;
            });
            //启动任务,并安排到当前任务队列线程中执行任务(System.Threading.Tasks.TaskScheduler)
            task.Start();

            Console.WriteLine("主线程执行其他处理");
            //等待任务的完成执行过程。
            task.Wait();
            //获得任务的执行结果
            Console.WriteLine("任务执行结果：{0}", task.Result.ToString());
        }

        /// <summary>
        /// 使用ContinueWith方法在任务完成时启动一个新任务
        /// </summary>
        static void TaskContinueWith()
        {
            Task<int> task = new Task<int>(() =>
            {
                int sum = 0;
                Console.WriteLine("使用Task执行异步操作.");
                for (int i = 0; i < 100; i++)
                {
                    sum += i;
                }
                return sum;
            });
            //启动任务,并安排到当前任务队列线程中执行任务(System.Threading.Tasks.TaskScheduler)
            task.Start();
            Console.WriteLine("主线程执行其他处理");
            //任务完成时执行处理。
            Task cwt = task.ContinueWith(t =>
            {
                Console.WriteLine("任务完成后的执行结果：{0}", t.Result.ToString());
            });
            Thread.Sleep(1000);
        }
        /// <summary>
        /// 创建父子任务和任务工厂的使用
        /// </summary>
        private static void ParentChildTask()
        {
            Task<string[]> parent = new Task<string[]>(state =>
            {
                Console.WriteLine(state);
                string[] result = new string[2];
                //创建并启动子任务
                new Task(() => { result[0] = "我是子任务1。"; }, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => { result[1] = "我是子任务2。"; }, TaskCreationOptions.AttachedToParent).Start();
                return result;
            }, "我是父任务，并在我的处理过程中创建多个子任务，所有子任务完成以后我才会结束执行。");
            //任务处理完成后执行的操作
            parent.ContinueWith(t =>
            {
                Array.ForEach(t.Result, r => Console.WriteLine(r));
            });
            //启动父任务
            parent.Start();
            Console.Read();
        }


        static void TaskFactoryApply()
        {
            Task parent = new Task(() =>
            {
                CancellationTokenSource cts = new CancellationTokenSource(5000);

                //创建任务工厂
                TaskFactory tf = new TaskFactory(cts.Token, TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
                //添加一组具有相同状态的子任务
                Task[] task = new Task[]{
                 tf.StartNew(() => { Console.WriteLine("我是任务工厂里的第一个任务。"); }),
                 tf.StartNew(() => { Console.WriteLine("我是任务工厂里的第二个任务。"); }),
                 tf.StartNew(() => { Console.WriteLine("我是任务工厂里的第三个任务。"); })
                };
            });
            parent.Start();


            Console.Read();
        }


        /// <summary>
        /// SynchronizationContextTaskScheduler任务调度器能够用在Window form、WPF等应用程序，
        /// 他的任务调度是采用的GUI线程
        /// </summary>
        static void TaskSchedulerTask()
        {

            TaskScheduler m_syncContextTaskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            Task<int> task = new Task<int>(() =>
             {
                 //执行复杂的计算任务。
                 Thread.Sleep(2000);
                 int sum = 0;
                 for (int i = 0; i < 100; i++)
                 {
                     sum += i;
                 }
                 return sum;
             });
            var cts = new CancellationTokenSource();
            //任务完成时启动一个后续任务，并采用同步上下文任务调度器调度任务更新UI组件。
            task.ContinueWith(t => { Console.WriteLine("采用SynchronizationContextTaskScheduler任务调度器更新UI。\r\n计算结果是：" + task.Result.ToString());  },
               cts.Token, TaskContinuationOptions.AttachedToParent, m_syncContextTaskScheduler);
            task.Start();
        }

        /// <summary>
        /// 任务的取消
        /// Cooperative Cancellation模式
        /// </summary>
        public static void CancellationTask()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Task t = new Task(() =>
            {
 
                //此处方法模拟一个耗时的工作 
                for (int i = 0; i < 1000; i++)
                {
                    if (!cts.Token.IsCancellationRequested)
                    {
                        Thread.Sleep(500);
                        Console.Write(".");
                    }
                    else
                    {
                        Console.WriteLine("任务取消");
                        break;
                    }
                }
            },cts.Token );
            t.Start();
            Thread.Sleep(2000);
            cts.Cancel();
            Console.Read();
        }


        public async Task<int> SumPageSizesAsync2(IList<Uri> uris)
        {
            var tasks = uris.Select(uri => new WebClient().DownloadDataTaskAsync(uri));
            var data = await Task.WhenAll(tasks);
            return await Task.Run(() =>
            {
                return data.Sum(s => s.Length);
            });
        }
    }
}
