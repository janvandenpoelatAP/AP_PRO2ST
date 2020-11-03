using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningMockingWeekend
{
    public class Greeter
    {
        private readonly IDateGetter dateGetter;

        public Greeter(IDateGetter dateGetter)
        {
            this.dateGetter = dateGetter;
        }

        public string GetMessage()
        {
            var date = dateGetter.GetDate();
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return "Party time.....it's weekend";
            }
            return "Work hard, weekend is on his way....";
        }
    }
}
