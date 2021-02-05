using RRQMSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RRQMClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem((object o) =>
                {
                    RRQMTcpClientTest();
                });
            }
            Console.ReadKey();
        }
        static TimeSpan time;
        static int count;
        static void SimpleTcpClientTest()
        {
            SimpleTcpClient client = new SimpleTcpClient();

            ConnectSetting connectSetting = new ConnectSetting();
            connectSetting.TargetIP = "127.0.0.1";
            connectSetting.TargetPort = 7789;

            client.Connect(connectSetting);
            Console.WriteLine("连接成功");

            TimeSpan timeSpan = RRQMCore.Diagnostics.TimeMeasurer.Run(() =>
              {
                  for (int i = 0; i < 1000000; i++)
                  {
                      if (i % 10000 == 0)
                      {
                          Console.WriteLine(i);
                      }
                      client.Send(Encoding.UTF8.GetBytes("若汝棋茗"));
                  }
              });
            lock (typeof(Program))
            {
                count++;
                time += timeSpan;
                Console.WriteLine(TimeSpan.FromTicks(time.Ticks / count));
            }

        }

        static void RRQMTcpClientTest()
        {
            RRQMTcpClient client = new RRQMTcpClient();

            ConnectSetting connectSetting = new ConnectSetting();
            connectSetting.TargetIP = "127.0.0.1";
            connectSetting.TargetPort = 7790;
            client.Connect(connectSetting);
            Console.WriteLine("连接成功");

            byte[] data = Encoding.UTF8.GetBytes("若汝棋茗");
            TimeSpan timeSpan = RRQMCore.Diagnostics.TimeMeasurer.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    if (i % 10000 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    client.Send(data);
                }
            });
            lock (typeof(Program))
            {
                count++;
                time += timeSpan;
                Console.WriteLine(TimeSpan.FromTicks(time.Ticks / count));
            }
        }
    }
}
