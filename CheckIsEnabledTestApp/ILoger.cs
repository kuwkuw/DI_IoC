using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIsEnabledTestApp
{
    interface ILoger
    {
        void Log(ResponseStatus responseStatus, string resourceUrl);
    }
}
