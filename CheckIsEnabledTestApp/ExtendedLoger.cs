using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIsEnabledTestApp
{
    class ExtendedLoger: ILoger
    {
        public void Log(ResponseStatus responseStatus, string resourceUrl)
        {
            Console.WriteLine("Console and file loger URL: {1} | Status: {0}", responseStatus, resourceUrl);
            using (var stWr = new StreamWriter(@"../log.txt",true))
            {
                var sb = new StringBuilder(String.Format("{0} | {1} | {2}",  DateTime.Now.ToString(), resourceUrl, responseStatus));
                stWr.WriteLine(sb);
            }
        }
    }
}
