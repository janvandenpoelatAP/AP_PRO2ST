using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningMockingWeekend
{
    public class DateGetter : IDateGetter
    {
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
