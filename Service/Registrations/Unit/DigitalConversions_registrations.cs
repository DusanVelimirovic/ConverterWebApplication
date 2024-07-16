using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    public class DigitalConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            // Bits
            service.RegisterConversion(new BitsToBytes());
            service.RegisterConversion(new BitsToKilobits());
            service.RegisterConversion(new BitsToKilobytes());
            service.RegisterConversion(new BitsToMegabits());
            service.RegisterConversion(new BitsToMegabytes());
            service.RegisterConversion(new BitsToGigabits());
            service.RegisterConversion(new BitsToGigabytes());
            service.RegisterConversion(new BitsToTerabits());
            service.RegisterConversion(new BitsToTerabytes());

            // Bytes
            service.RegisterConversion(new BytesToBits());
            service.RegisterConversion(new BytesToKilobits());
            service.RegisterConversion(new BytesToKilobytes());
            service.RegisterConversion(new BytesToMegabits());
            service.RegisterConversion(new BytesToMegabytes());
            service.RegisterConversion(new BytesToGigabits());
            service.RegisterConversion(new BytesToGigabytes());
            service.RegisterConversion(new BytesToTerabits());
            service.RegisterConversion(new BytesToTerabytes());

            // Kilobits
            service.RegisterConversion(new KilobitsToBits());
            service.RegisterConversion(new KilobitsToBytes());
            service.RegisterConversion(new KilobitsToKilobytes());
            service.RegisterConversion(new KilobitsToMegabits());
            service.RegisterConversion(new KilobitsToMegabytes());
            service.RegisterConversion(new KilobitsToGigabits());
            service.RegisterConversion(new KilobitsToGigabytes());
            service.RegisterConversion(new KilobitsToTerabits());
            service.RegisterConversion(new KilobitsToTerabytes());

            // Kilobytes
            service.RegisterConversion(new KilobytesToBits());
            service.RegisterConversion(new KilobytesToBytes());
            service.RegisterConversion(new KilobytesToKilobits());
            service.RegisterConversion(new KilobytesToMegabits());
            service.RegisterConversion(new KilobytesToMegabytes());
            service.RegisterConversion(new KilobytesToGigabits());
            service.RegisterConversion(new KilobytesToGigabytes());
            service.RegisterConversion(new KilobytesToTerabits());
            service.RegisterConversion(new KilobytesToTerabytes());

            // Megabits
            service.RegisterConversion(new MegabitsToBits());
            service.RegisterConversion(new MegabitsToBytes());
            service.RegisterConversion(new MegabitsToKilobits());
            service.RegisterConversion(new MegabitsToKilobytes());
            service.RegisterConversion(new MegabitsToMegabytes());
            service.RegisterConversion(new MegabitsToGigabits());
            service.RegisterConversion(new MegabitsToGigabytes());
            service.RegisterConversion(new MegabitsToTerabits());
            service.RegisterConversion(new MegabitsToTerabytes());

            // Megabytes
            service.RegisterConversion(new MegabytesToBits());
            service.RegisterConversion(new MegabytesToBytes());
            service.RegisterConversion(new MegabytesToKilobits());
            service.RegisterConversion(new MegabytesToKilobytes());
            service.RegisterConversion(new MegabytesToMegabits());
            service.RegisterConversion(new MegabytesToGigabits());
            service.RegisterConversion(new MegabytesToGigabytes());
            service.RegisterConversion(new MegabytesToTerabits());
            service.RegisterConversion(new MegabytesToTerabytes());

            // Gigabits
            service.RegisterConversion(new GigabitsToBits());
            service.RegisterConversion(new GigabitsToBytes());
            service.RegisterConversion(new GigabitsToKilobits());
            service.RegisterConversion(new GigabitsToKilobytes());
            service.RegisterConversion(new GigabitsToMegabits());
            service.RegisterConversion(new GigabitsToMegabytes());
            service.RegisterConversion(new GigabitsToGigabytes());
            service.RegisterConversion(new GigabitsToTerabits());
            service.RegisterConversion(new GigabitsToTerabytes());

            // Gigabytes
            service.RegisterConversion(new GigabytesToBits());
            service.RegisterConversion(new GigabytesToBytes());
            service.RegisterConversion(new GigabytesToKilobits());
            service.RegisterConversion(new GigabytesToKilobytes());
            service.RegisterConversion(new GigabytesToMegabits());
            service.RegisterConversion(new GigabytesToMegabytes());
            service.RegisterConversion(new GigabytesToGigabits());
            service.RegisterConversion(new GigabytesToTerabits());
            service.RegisterConversion(new GigabytesToTerabytes());

            // Terabits
            service.RegisterConversion(new TerabitsToBits());
            service.RegisterConversion(new TerabitsToBytes());
            service.RegisterConversion(new TerabitsToKilobits());
            service.RegisterConversion(new TerabitsToKilobytes());
            service.RegisterConversion(new TerabitsToMegabits());
            service.RegisterConversion(new TerabitsToMegabytes());
            service.RegisterConversion(new TerabitsToGigabits());
            service.RegisterConversion(new TerabitsToGigabytes());
            service.RegisterConversion(new TerabitsToTerabytes());

            // Terabytes
            service.RegisterConversion(new TerabytesToBits());
            service.RegisterConversion(new TerabytesToBytes());
            service.RegisterConversion(new TerabytesToKilobits());
            service.RegisterConversion(new TerabytesToKilobytes());
            service.RegisterConversion(new TerabytesToMegabits());
            service.RegisterConversion(new TerabytesToMegabytes());
            service.RegisterConversion(new TerabytesToGigabits());
            service.RegisterConversion(new TerabytesToGigabytes());
            service.RegisterConversion(new TerabytesToTerabits());
        }
    }
}
