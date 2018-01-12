using Exceptionless;
using Exceptionless.Models;
using System;
using System.Collections.Generic;

namespace ExceptionlessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionlessClient.Default.Startup("07Hj82ie9Ty82uhm7J8uIseyf3FEK0XRhct0VfXr");
            ExceptionlessClient.Default.Configuration.UseSessions();
            ExceptionlessClient.Default.Configuration.SetUserIdentity("yuanhuaming@aliyun.com","袁");



            ExceptionlessClient.Default.SubmitSessionStart();
           
           
        
            // SendLog();

            //ExceptionlessClient.Default.SubmitSessionHeartbeat();
            ThrowException();
            ExceptionlessClient.Default.SubmitSessionEnd();
            Console.Read();
        }

        public static void SendLog()
        {

            // 发送日志
            ExceptionlessClient.Default.SubmitLog("Logging made easy");

            // 你可以指定日志来源，和日志级别。
            // 日志级别有这几种: Trace, Debug, Info, Warn, Error
            ExceptionlessClient.Default.SubmitLog(nameof(Program), "This is so easy", "Info");
            ExceptionlessClient.Default.CreateLog(typeof(Program).FullName, "This is so easy", "Info").AddTags("Exceptionless").Submit();

            // 发送特征 Feature Usages
            ExceptionlessClient.Default.SubmitFeatureUsage("MyFeature");
            ExceptionlessClient.Default.CreateFeatureUsage("MyFeature").AddTags("Exceptionless").Submit();

            // 发送一个 404 
            ExceptionlessClient.Default.SubmitNotFound("/somepage");
            ExceptionlessClient.Default.CreateNotFound("/somepage").AddTags("Exceptionless").Submit();

            // 发生一个自定义事件
            ExceptionlessClient.Default.SubmitEvent(new Event { Message = "Low Fuel", Type = "racecar", Source = "Fuel System" });
            

        }


 

        public static void ThrowException()
        {
            try
            {
                var fenmu = 0;
                var num = 10 / fenmu;
            }
            catch (Exception ex)
            {
                //手动发送一个已处理的异常
                //ex.ToExceptionless().SetManualStackingKey(nameof(Program)).Submit();
                ex.ToExceptionless().SetManualStackingInfo("aaa", new Dictionary<string, string> {
                    { "Controller", nameof(Program) },
                    { "Action", nameof(ThrowException) }
                });
                //ex.ToExceptionless().Submit();
                Console.WriteLine(ex.Message);
            }
  
        }
    }
}
