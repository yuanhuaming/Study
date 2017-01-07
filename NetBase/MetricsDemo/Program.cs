
using Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsDemo
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Metric.Config
                // Web监视仪表板，提供Metrics.NET度量值图表
                .WithHttpEndpoint("http://localhost:1234/metrics/")
                // 配置报表输出
                .WithReporting((rc) =>
                {
                    // 报表输出到控制台
                    rc.WithConsoleReport(TimeSpan.FromSeconds(5));
                });

            GaugeTest();
            CounterTest();
            HistogramTest();
            MeterTest();
            TimerTest();
            HealthCheckTest();

            Console.ReadLine();
        }

        static Random ran = new Random(DateTime.Now.TimeOfDay.Milliseconds);

        static void GaugeTest()
        {
            Metric.Gauge("test.gauge", () => ran.NextDouble() * 1000, Unit.None);
        }

        static void CounterTest()
        {
            var counter = Metric.Counter("test.counter", Unit.Custom("并发"));

            Action doWork = () => { System.Threading.Thread.Sleep(ran.Next(10, 300)); };
            Action idlesse = () => { System.Threading.Thread.Sleep(ran.Next(0, 500)); };
            for (var i = 0; i < 20; i++)
            {
                Task.Run(() =>
                {
                    while (true)
                    {
                        counter.Increment();
                        doWork();
                        counter.Decrement();
                        idlesse();
                    }
                });
            }
        }

        static void HistogramTest()
        {
            var histogram = Metric.Histogram("test.histogram", Unit.Custom("岁"), SamplingType.LongTerm);


            Task.Run(() =>
            {
                while (true)
                {
                    histogram.Update(ran.Next(10, 80), ran.Next(0, 2) > 0 ? "男" : "女");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            });
        }

        static void MeterTest()
        {
            var meter = Metric.Meter("test.meter", Unit.Calls, TimeUnit.Seconds);

            Action idlesse = () => { System.Threading.Thread.Sleep(ran.Next(20, 50)); };
            Task.Run(() => {
                while (true)
                {
                    meter.Mark();
                    idlesse();
                }
            });
        }

        static void TimerTest()
        {
            var timer = Metric.Timer("test.meter", Unit.None, SamplingType.Default, TimeUnit.Seconds, TimeUnit.Microseconds);

            Action doWork = () => { System.Threading.Thread.Sleep(ran.Next(10, 300)); };
            Action idlesse = () => { System.Threading.Thread.Sleep(ran.Next(0, 500)); };
            for (var i = 0; i < 20; i++)
            {
                Task.Run(() =>
                {
                    while (true)
                    {
                        timer.Time(doWork);
                        idlesse();
                    }
                });
            }
        }

        static void HealthCheckTest()
        {
            HealthChecks.RegisterHealthCheck("test.healthcheck", () =>
            {
                return ran.Next(100) < 5 ? HealthCheckResult.Unhealthy() : HealthCheckResult.Healthy();
            });
        }

    }
}
