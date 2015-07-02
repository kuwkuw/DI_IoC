using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace CheckIsEnabledTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = @"http://dou.ua/";

            CheckResponsWihtConsolelLoger(url);
            Console.ReadLine();
        }

        static void CheckResponsWihtConsolelLoger(string url)
        {
            var respChk = new ResponseChecker();
            IKernel kernel = new StandardKernel();
            kernel.Bind<ResponseChecker>().ToSelf();
            respChk.CheckResponse(@"http://dou.ua/");
        }

        static void CheckResponsWihtFileLoger(string url)
        {
            var respChk = new ResponseChecker();
            IKernel kernel = new StandardKernel();
            kernel.Bind<ILoger>().To<ToFileLoger>();
            respChk.CheckResponse(@"http://dou.ua/");
        }

        static void CheckResponsWihtFileAndConsoleLoger(string url)
        {
            var respChk = new ResponseChecker();
            IKernel kernel = new StandardKernel();
            kernel.Bind<ILoger>().To<ExtendedLoger>();
            respChk.CheckResponse(@"http://dou.ua/");
        }
    }
}
