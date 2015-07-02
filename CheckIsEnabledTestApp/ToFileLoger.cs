using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIsEnabledTestApp
{
    class ToFileLoger: ILoger
    {
        public void Log(ResponseStatus responseStatus, string resourceUrl)
        {
            Console.WriteLine("File loger");
            using (Stream st = File.Open("../log.txt",FileMode.OpenOrCreate, FileAccess.Write))
            {
                var stWr =new StreamWriter(st);
                var sb = new StringBuilder(String.Format("{0} | {1}\n", resourceUrl, responseStatus));
                
                stWr.WriteLine(sb);
                stWr.Flush();
            }
        }
    }
}
