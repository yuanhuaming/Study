using System;
using System.CodeDom;
using System.IO;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using 并行编程;
using static System.Math;
class Program
{
    static void Main(string[] args)
    {

        string aa = "123";
        object bb = "123";
        Console.WriteLine(ReferenceEquals(aa,bb));
        Console.WriteLine(aa.GetHashCode() );
        Console.WriteLine(bb.GetHashCode());
        Console.WriteLine(Equals(aa,bb));
        Console .WriteLine(并行聚合.ParallelSum());
        //DoKeyword1();
        DoSomethingAsync();
        TryTodoAsync();
        Console.ReadKey();
    }


    public static void Invoke(params Action[] actions)
    {
        foreach (var action in actions)
        {
            var task = new Task(action);
           // task.Start();

            task.Wait();
        }
    }

    public static async Task DoSomethingAsync()
    {
        int val = 13;
          Task.Delay(TimeSpan.FromSeconds(5));
        val *= 2;
        await  Task.Delay(TimeSpan.FromSeconds(5));
        Console.WriteLine(val);
    }

    public static void TryTodoAsync()
    {
        try
        {
     
            Parallel.Invoke(() => { throw new Exception("sdfsdfsdfs"); } );
        }
        catch (AggregateException ex)
        {
            Console.WriteLine(ex.Message);
            ex.Handle(e =>
            {
                Console.WriteLine(e.Message);
                return true;
            });
                     

        }
        //catch (Exception ex)
        //{
           
        //   Console.WriteLine(ex.InnerException);
        //}
    }

    public static async Task CallProgress()
    {
        var progress=new Progress<double>();
        progress.ProgressChanged += Progress_ProgressChanged;

        await ProgressAsync(progress);
    }

    private static void Progress_ProgressChanged(object sender, double e)
    {
        throw new NotImplementedException();
    }

    public static async Task ProgressAsync(IProgress<double> progress)
    {
        double flag = 0;
        //while (!done)
        //{
        //    if (progress!=null)
        //    {
        //        progress.Report(flag);
        //    }
        //}
    }


}