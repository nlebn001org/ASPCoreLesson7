using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreLesson7AdditionalTask.Services
{
    public class WebTimer : IWebClock
    {
        public DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}
