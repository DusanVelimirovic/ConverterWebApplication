using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    public class TimeConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            // Bits
            // Seconds
            service.RegisterConversion(new SecondsToMinutes());
            service.RegisterConversion(new SecondsToHours());
            service.RegisterConversion(new SecondsToDays());
            service.RegisterConversion(new SecondsToWeeks());
            service.RegisterConversion(new SecondsToMonths());
            service.RegisterConversion(new SecondsToYears());

            // Minutes
            service.RegisterConversion(new MinutesToSeconds());
            service.RegisterConversion(new MinutesToHours());
            service.RegisterConversion(new MinutesToDays());
            service.RegisterConversion(new MinutesToWeeks());
            service.RegisterConversion(new MinutesToMonths());
            service.RegisterConversion(new MinutesToYears());

            // Hours
            service.RegisterConversion(new HoursToSeconds());
            service.RegisterConversion(new HoursToMinutes());
            service.RegisterConversion(new HoursToDays());
            service.RegisterConversion(new HoursToWeeks());
            service.RegisterConversion(new HoursToMonths());
            service.RegisterConversion(new HoursToYears());

            // Days
            service.RegisterConversion(new DaysToSeconds());
            service.RegisterConversion(new DaysToMinutes());
            service.RegisterConversion(new DaysToHours());
            service.RegisterConversion(new DaysToWeeks());
            service.RegisterConversion(new DaysToMonths());
            service.RegisterConversion(new DaysToYears());

            // Weeks
            service.RegisterConversion(new WeeksToSeconds());
            service.RegisterConversion(new WeeksToMinutes());
            service.RegisterConversion(new WeeksToHours());
            service.RegisterConversion(new WeeksToDays());
            service.RegisterConversion(new WeeksToMonths());
            service.RegisterConversion(new WeeksToYears());

            // Months
            service.RegisterConversion(new MonthsToSeconds());
            service.RegisterConversion(new MonthsToMinutes());
            service.RegisterConversion(new MonthsToHours());
            service.RegisterConversion(new MonthsToDays());
            service.RegisterConversion(new MonthsToWeeks());
            service.RegisterConversion(new MonthsToYears());

            // Years
            service.RegisterConversion(new YearsToSeconds());
            service.RegisterConversion(new YearsToMinutes());
            service.RegisterConversion(new YearsToHours());
            service.RegisterConversion(new YearsToDays());
            service.RegisterConversion(new YearsToWeeks());
            service.RegisterConversion(new YearsToMonths());
        }
    }
}
