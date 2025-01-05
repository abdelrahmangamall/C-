namespace d28
{
    public static class ProgramBase
    {
        public static bool isWeekDay(this DateTime value)
        {
            return !(isweekend(value));
        }
        public static bool isweekend(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}