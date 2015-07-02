using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIsEnabledTestApp
{
    class ConsoleLoger : ILoger
    {
        public void Log(ResponseStatus responseStatus, string resourceUrl)
        {
            Console.WriteLine("Console loger URL: {1} | Status: {0}", responseStatus, resourceUrl);
        }
    }
}
