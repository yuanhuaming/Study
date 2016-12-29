using System;
using System.CodeDom;
using System.Diagnostics;
using System.IO;
 
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
 
class Program
{
    static void Main(string[] args)
    {
        //F_运算符号();

        GetCurrentMethod();
        Console.ReadKey();
    }

    /// <summary>
    /// 获取堆栈内的执行方法
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetCurrentMethod()
    {
        StackTrace st = new StackTrace();
        StackFrame[] sf = st.GetFrames();
        Console.WriteLine(st.GetFrame(0).GetMethod().Name);
        foreach (var item in sf)
        {

            Console.WriteLine(item.GetMethod().Name);
        }
        
    }


    public static void F_运算符号()
    {
        ClassA a= new ClassA();
        if (a.HotelSotck == -1 | a.HotelSotck * a.MaxAdultAmount > a.FlightStock)
            Console.WriteLine("    |     ");
        if (a.HotelSotck == -1 || a.HotelSotck * a.MaxAdultAmount > a.FlightStock)
            Console.WriteLine("    ||     ");

    }
  
}

class ClassA
{
    /// <summary>
    /// 酒店库存
    /// </summary>
    public int HotelSotck { get; set; } = 2;

    /// <summary>
    /// 酒店入住人数
    /// </summary>
    public int MaxAdultAmount { get; set; } = 1;

    /// <summary>
    /// 机票库存
    /// </summary>
    public int FlightStock { get; set; } = -1;

}