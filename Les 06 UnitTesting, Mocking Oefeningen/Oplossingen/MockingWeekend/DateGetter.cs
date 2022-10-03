namespace MockingWeekend
{
    public class DateGetter : IDateGetter
    {
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
