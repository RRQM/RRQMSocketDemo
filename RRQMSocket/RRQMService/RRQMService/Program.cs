using RRQMSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRQMServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleTcpServiceTest();
            RRQMTcpServiceTest();
            Console.ReadKey();
        }


        static void SimpleTcpServiceTest()
        {
            SimpleTcpService service = new SimpleTcpService();
            BindSetting setting = new BindSetting();
            setting.IP = "127.0.0.1";
            setting.Port = 7789;
            setting.MultithreadThreadCount = 10;
            service.Bind(setting);

            
            Console.WriteLine("绑定成功");
        }
        
        static void RRQMTcpServiceTest()
        {
            RRQMTcpService service = new RRQMTcpService();
            BindSetting setting = new BindSetting();
            setting.IP = "127.0.0.1";
            setting.Port = 7790;
            setting.MultithreadThreadCount = 1;
            service.Bind(setting);
            Console.WriteLine("绑定成功");
        }
    }
}
