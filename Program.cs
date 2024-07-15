using Converter_Web_Application;
using Converter_Web_Application.Service;
using Converter_Web_Application.Service.Implementations;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Threading.Tasks;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register translation service
builder.Services.AddScoped<TranslationService>();



// Register ConversionManagerService as a singleton
builder.Services.AddSingleton<ConversionManagerService>(sp =>
{
    var service = new ConversionManagerService();
    // Register Lenght conversions

    // Meters
    service.RegisterConversion(new MetersToKilometers());
    service.RegisterConversion(new MetersToMiles());
    service.RegisterConversion(new MetersToCentimeters());
    service.RegisterConversion(new MetersToMillimeters());
    service.RegisterConversion(new MetersToFeet());
    service.RegisterConversion(new MetersToYards());
    service.RegisterConversion(new MetersToNauticalMiles());
    service.RegisterConversion(new MetersToInches());
    service.RegisterConversion(new MetersToLeagues());

    // Kilometers
    service.RegisterConversion(new KilometersToMiles());
    service.RegisterConversion(new KilometersToMeters());
    service.RegisterConversion(new KilometersToNauticalMiles());
    service.RegisterConversion(new KilometersToCentimeters());
    service.RegisterConversion(new KilometersToMillimeters());
    service.RegisterConversion(new KilometersToYards());
    service.RegisterConversion(new KilometersToFeet());
    service.RegisterConversion(new KilometersToInches());
    service.RegisterConversion(new KilometersToLeagues());

    // Miles
    service.RegisterConversion(new MilesToKilometers());
    service.RegisterConversion(new MilesToMeters());
    service.RegisterConversion(new MilesToCentimeters());
    service.RegisterConversion(new MilesToMillimeters());
    service.RegisterConversion(new MilesToNauticalMiles());
    service.RegisterConversion(new MilesToYards());
    service.RegisterConversion(new MilesToFeet());
    service.RegisterConversion(new MilesToInches());
    service.RegisterConversion(new MilesToLeagues());

    // Centimeters
    service.RegisterConversion(new CentimetersToInches());
    service.RegisterConversion(new CentimetersToKilometers());
    service.RegisterConversion(new CentimetersToMiles());
    service.RegisterConversion(new CentimetersToMillimeters());
    service.RegisterConversion(new CentimetersToNauticalMiles());
    service.RegisterConversion(new CentimetersToYards());
    service.RegisterConversion(new CentimetersToFeet());
    service.RegisterConversion(new CentimetersToMeters());
    service.RegisterConversion(new CentimetersToLeagues());

    // Millimeters
    service.RegisterConversion(new MillimetersToMeters());
    service.RegisterConversion(new MillimetersToKilometers());
    service.RegisterConversion(new MillimetersToMiles());
    service.RegisterConversion(new MillimetersToCentimeters());
    service.RegisterConversion(new MillimetersToYards());
    service.RegisterConversion(new MillimetersToFeet());
    service.RegisterConversion(new MillimetersToNauticalMiles());
    service.RegisterConversion(new MillimetersToInches());
    service.RegisterConversion(new MillimetersToLeagues());

    // Nautical miles
    service.RegisterConversion(new NauticalMilesToKilometers());
    service.RegisterConversion(new NauticalMilesToMeters());
    service.RegisterConversion(new NauticalMilesToCentimeters());
    service.RegisterConversion(new NauticalMilesToMillimeters());
    service.RegisterConversion(new NauticalMilesToYards());
    service.RegisterConversion(new NauticalMilesToFeet());
    service.RegisterConversion(new NauticalMilesToInches());
    service.RegisterConversion(new NauticalMilesToLeagues());

    // Yards
    service.RegisterConversion(new YardsToMeters());
    service.RegisterConversion(new YardsToKilometers());
    service.RegisterConversion(new YardsToMiles());
    service.RegisterConversion(new YardsToCentimeters());
    service.RegisterConversion(new YardsToMillimeters());
    service.RegisterConversion(new YardsToNauticalMiles());
    service.RegisterConversion(new YardsToInches());
    service.RegisterConversion(new YardsToFeet());
    service.RegisterConversion(new YardsToLeagues());

    // Feets
    service.RegisterConversion(new FeetToMeters());
    service.RegisterConversion(new FeetToKilometers());
    service.RegisterConversion(new FeetToMiles());
    service.RegisterConversion(new FeetToCentimeters());
    service.RegisterConversion(new FeetToMillimeters());
    service.RegisterConversion(new FeetToNauticalMiles());
    service.RegisterConversion(new FeetToYards());
    service.RegisterConversion(new FeetToInches());
    service.RegisterConversion(new FeetToLeagues());

    // Inches
    service.RegisterConversion(new InchesToCentimeters());
    service.RegisterConversion(new InchesToMeters());
    service.RegisterConversion(new InchesToKilometers());
    service.RegisterConversion(new InchesToMiles());
    service.RegisterConversion(new InchesToMillimeters());
    service.RegisterConversion(new InchesToNauticalMiles());
    service.RegisterConversion(new InchesToYards());
    service.RegisterConversion(new InchesToFeet());
    service.RegisterConversion(new InchesToLeagues());


    // Leagues
    service.RegisterConversion(new LeaguesToKilometers());
    service.RegisterConversion(new LeaguesToMeters());
    service.RegisterConversion(new LeaguesToCentimeters());
    service.RegisterConversion(new LeaguesToMillimeters());
    service.RegisterConversion(new LeaguesToNauticalMiles());
    service.RegisterConversion(new LeaguesToYards());
    service.RegisterConversion(new LeaguesToFeet());
    service.RegisterConversion(new LeaguesToInches());
    service.RegisterConversion(new LeaguesToMiles());

    // Register Weight conversions

    // Grams
    service.RegisterConversion(new GramsToKilograms());
    service.RegisterConversion(new GramsToOunces());
    service.RegisterConversion(new GramsToPoundes());
    service.RegisterConversion(new GramsToStones());

    // Kilograms
    service.RegisterConversion(new KilogramsToGrams());
    service.RegisterConversion(new KilogramsToOunces());
    service.RegisterConversion(new KilogramsToPounds());
    service.RegisterConversion(new KilogramsToStones());

    // Ounces
    service.RegisterConversion(new OuncesToGrams());
    service.RegisterConversion(new OuncesToKilograms());
    service.RegisterConversion(new OuncesToPounds());
    service.RegisterConversion(new OuncesToStones());

    // Pounds
    service.RegisterConversion(new PoundsToGrams());
    service.RegisterConversion(new PoundsToKilograms());
    service.RegisterConversion(new PoundsToOunces());
    service.RegisterConversion(new PoundsToStones());

    // Stones
    service.RegisterConversion(new StonesToGrams());
    service.RegisterConversion(new StonesToKilograms());
    service.RegisterConversion(new StonesToOunces());
    service.RegisterConversion(new StonesToPoundes());

    // Register Volume conversions

    // Cubic Centimeters
    service.RegisterConversion(new CubicCentimetersToCubicInches());
    service.RegisterConversion(new CubicCentimetersToCubicMeters());
    service.RegisterConversion(new CubicCentimetersToLiters());
    service.RegisterConversion(new CubicCentimetersToMilliliters());

    // Cubic Inches
    service.RegisterConversion(new CubicInchesToCubicCentimeters());
    service.RegisterConversion(new CubicInchesToCubicMeters());
    service.RegisterConversion(new CubicInchesToLiters());
    service.RegisterConversion(new CubicInchesToMilliliters());

    // Cubic Meters
    service.RegisterConversion(new CubicMetersToCubicCentimeters());
    service.RegisterConversion(new CubicMetersToCubicInches());
    service.RegisterConversion(new CubicMetersToLiters());
    service.RegisterConversion(new CubicMetersToMilliliters());

    // Liters
    service.RegisterConversion(new LitersToCubicCentimeters());
    service.RegisterConversion(new LitersToCubicInches());
    service.RegisterConversion(new LitersToCubicMeters());
    service.RegisterConversion(new LitersToMilliliters());

    // Milliliters
    service.RegisterConversion(new MillilitersToCubicInches());
    service.RegisterConversion(new MillilitersToCubicMeters());
    service.RegisterConversion(new MillilitersToLiters());
    service.RegisterConversion(new MillilitersToCubicCentimeters());

    // Register Temperature conversions
    service.RegisterConversion(new CelsiusToFahrenheit());
    service.RegisterConversion(new CelsiusToKelvin());
    service.RegisterConversion(new FahrenheitToCelsius());
    service.RegisterConversion(new FahrenheitToKelvin());
    service.RegisterConversion(new KelvinToCelsius());
    service.RegisterConversion(new KelvinToFahrenheit());

    // Register Area conversions

    // Square meters
    service.RegisterConversion(new SquaremetersToSquareFeet());
    service.RegisterConversion(new SquaremetersToSquareYards());
    service.RegisterConversion(new SquaremetersToSquareMiles());
    service.RegisterConversion(new SquaremetersToSquareKilometers());
    service.RegisterConversion(new SquaremetersToAcres());
    service.RegisterConversion(new SquaremetersToHectares());
    service.RegisterConversion(new SquaremetersToSquereCentimeters());
    service.RegisterConversion(new SquaremetersToSquereInches());
    service.RegisterConversion(new SquaremetersToSquereMillimeters());

    // Square feet
    service.RegisterConversion(new SquareFeetToSquereMeters());
    service.RegisterConversion(new SquareFeetToSquereYards());
    service.RegisterConversion(new SquareFeetToSquereMiles());
    service.RegisterConversion(new SquareFeetToSquereKilometers());
    service.RegisterConversion(new SquareFeetToAcres());
    service.RegisterConversion(new SquareFeetToHectares());
    service.RegisterConversion(new SquareFeetToSquareCentimeters());
    service.RegisterConversion(new SquareFeetToSquareInches());
    service.RegisterConversion(new SquareFeetToSquareMillimeters());

    // Square yards
    service.RegisterConversion(new SquareYardsToSquareMeters());
    service.RegisterConversion(new SquareYardsToSquareFeet());
    service.RegisterConversion(new SquareYardsToSquareMiles());
    service.RegisterConversion(new SquareYardsToSquareKilometers());
    service.RegisterConversion(new SquareYardsToAcres());
    service.RegisterConversion(new SquareYardsToHectares());
    service.RegisterConversion(new SquareYardsToSquareCentimeters());
    service.RegisterConversion(new SquareYardsToSquareInches());
    service.RegisterConversion(new SquareYardsToSquareMillimeters());

    // Square miles
    service.RegisterConversion(new SquareMilesToSquereMeters());
    service.RegisterConversion(new SquareMilesToSquereFeet());
    service.RegisterConversion(new SquareMilesToSquereYards());
    service.RegisterConversion(new SquareMilesToSquereKilometers());
    service.RegisterConversion(new SquareMilesToAcres());
    service.RegisterConversion(new SquareMilesToHectares());
    service.RegisterConversion(new SquareMilesToSquareCentimeters());
    service.RegisterConversion(new SquareMilesToSquareInches());
    service.RegisterConversion(new SquareMilesToSquareMillimeters());

    // Square kilometers
    service.RegisterConversion(new SquareKilometersToSquereMeters());
    service.RegisterConversion(new SquareKilometersToSquereFeet());
    service.RegisterConversion(new SquareKilometersToSquereYards());
    service.RegisterConversion(new SquareKilometersToSquereMiles());
    service.RegisterConversion(new SquareKilometersToAcres());
    service.RegisterConversion(new SquareKilometersToHectares());
    service.RegisterConversion(new SquareKilometersToCentimeters());
    service.RegisterConversion(new SquareKilometersToInches());
    service.RegisterConversion(new SquareKilometersToMillimeters());


    // Acres
    service.RegisterConversion(new AcresToMeters());
    service.RegisterConversion(new AcresToSquereFeet());
    service.RegisterConversion(new AcresToSquereYards());
    service.RegisterConversion(new AcresToSquereMiles());
    service.RegisterConversion(new AcresToSquereKilometers());
    service.RegisterConversion(new AcresToHectares());
    service.RegisterConversion(new AcresToSquareCentimeters());
    service.RegisterConversion(new AcresToSquareInches());
    service.RegisterConversion(new AcresToSquareMillimeters());

    // Hectares
    service.RegisterConversion(new HectaresToSquereMeters());
    service.RegisterConversion(new HectaresToSquereFeet());
    service.RegisterConversion(new HectaresToSquereYards());
    service.RegisterConversion(new HectaresToSquereMiles());
    service.RegisterConversion(new HectaresToSquereKilometers());
    service.RegisterConversion(new HectaresToAcres());
    service.RegisterConversion(new HectaresToSquareCentimeters());
    service.RegisterConversion(new HectaresToSquareInches());
    service.RegisterConversion(new HectaresToSquareMillimeters());

    // Square centimeters
    service.RegisterConversion(new SquereCentimetersToSquereInches());
    service.RegisterConversion(new SquereCentimetersToSquereMillimeters());
    service.RegisterConversion(new SquereCentimetersToSquareMeters());
    service.RegisterConversion(new SquereCentimetersToSquareFeet());
    service.RegisterConversion(new SquereCentimetersToSquareYards());
    service.RegisterConversion(new SquereCentimetersToSquareMiles());
    service.RegisterConversion(new SquereCentimetersToSquareKilometers());
    service.RegisterConversion(new SquereCentimetersToAcres());


    // Square inches
    service.RegisterConversion(new SquereInchesToSquereCentimeters());
    service.RegisterConversion(new SquereInchesToSquereMillimeters());
    service.RegisterConversion(new SquereInchesToSquereMeters());
    service.RegisterConversion(new SquereInchesToSquereFeet());
    service.RegisterConversion(new SquereInchesToSquereYards());
    service.RegisterConversion(new SquereInchesToSquereMiles());
    service.RegisterConversion(new SquereInchesToSquereKilometers());
    service.RegisterConversion(new SquereInchesToAcres());
    service.RegisterConversion(new SquereInchesToHectares());

    // Square millimeters
    service.RegisterConversion(new SquereMillimetersToSquereInches());
    service.RegisterConversion(new SquereMillimetersToSquereCentimeters());
    service.RegisterConversion(new SquereMillimetersToSquereMeters());
    service.RegisterConversion(new SquereMillimetersToSquereFeet());
    service.RegisterConversion(new SquereMillimetersToSquereYards());
    service.RegisterConversion(new SquereMillimetersToSquereMiles());
    service.RegisterConversion(new SquereMillimetersToSquereKilometers());
    service.RegisterConversion(new SquereMillimetersToAcres());
    service.RegisterConversion(new SquereMillimetersToHectares());

    // Register Time conversions

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

    // Register Digital storage conversions

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

    // Register Speed conversions

    // Meters per Second
    service.RegisterConversion(new MetersPerSecondToKilometersPerHour());
    service.RegisterConversion(new MetersPerSecondToMilesPerHour());
    service.RegisterConversion(new MetersPerSecondToFeetPerSecond());
    service.RegisterConversion(new MetersPerSecondToKnots());

    // Kilometers Per Hour
    service.RegisterConversion(new KilometersPerHourToMetersPerSecond());
    service.RegisterConversion(new KilometersPerHourToMilesPerHour());
    service.RegisterConversion(new KilometersPerHourToFeetPerSecond());
    service.RegisterConversion(new KilometersPerHourToKnots());

    // Miles per Hour
    service.RegisterConversion(new MilesPerHourToMetersPerSecond());
    service.RegisterConversion(new MilesPerHourToKilometersPerHour());
    service.RegisterConversion(new MilesPerHourToFeetPerSecond());
    service.RegisterConversion(new MilesPerHourToKnots());

    // Feet Per Second
    service.RegisterConversion(new FeetPerSecondToMetersPerSecond());
    service.RegisterConversion(new FeetPerSecondToKilometersPerHour());
    service.RegisterConversion(new FeetPerSecondToMilesPerHour());
    service.RegisterConversion(new FeetPerSecondToKnots());

    // Knots To Meters
    service.RegisterConversion(new KnotsToMetersPerSecond());
    service.RegisterConversion(new KnotsToKilometersPerHour());
    service.RegisterConversion(new KnotsToMilesPerHour());
    service.RegisterConversion(new KnotsToFeetPerSecond());


    // Register a Cooking conversions

    // Sugar Conversions
    service.RegisterConversion(new CupOfSugarToGrams());
    service.RegisterConversion(new CupOfSugarToKilograms());
    service.RegisterConversion(new CupOfSugarToOunces());
    service.RegisterConversion(new CupOfSugarToPounds());
    service.RegisterConversion(new TablespoonOfSugarToGrams());
    service.RegisterConversion(new TablespoonOfSugarToKilograms());
    service.RegisterConversion(new TablespoonOfSugarToOunces());
    service.RegisterConversion(new TablespoonOfSugarToPounds());
    service.RegisterConversion(new TeaspoonOfSugarToGrams());
    service.RegisterConversion(new TeaspoonOfSugarToKilograms());
    service.RegisterConversion(new TeaspoonOfSugarToOunces());
    service.RegisterConversion(new TeaspoonOfSugarToPounds());
    service.RegisterConversion(new GramsToCupsOfSugar());
    service.RegisterConversion(new KilogramsToCupsOfSugar());
    service.RegisterConversion(new OuncesToCupsOfSugar());
    service.RegisterConversion(new PoundsToCupsOfSugar());
    service.RegisterConversion(new GramsToTablespoonsOfSugar());
    service.RegisterConversion(new KilogramsToTablespoonsOfSugar());
    service.RegisterConversion(new OuncesToTablespoonsOfSugar());
    service.RegisterConversion(new PoundsToTablespoonsOfSugar());
    service.RegisterConversion(new GramsToTeaspoonsOfSugar());
    service.RegisterConversion(new KilogramsToTeaspoonsOfSugar());
    service.RegisterConversion(new OuncesToTeaspoonsOfSugar());
    service.RegisterConversion(new PoundsToTeaspoonsOfSugar());

    // Flour Conversions
    service.RegisterConversion(new CupOfFlourToGrams());
    service.RegisterConversion(new CupOfFlourToKilograms());
    service.RegisterConversion(new CupOfFlourToOunces());
    service.RegisterConversion(new CupOfFlourToPounds());
    service.RegisterConversion(new TablespoonOfFlourToGrams());
    service.RegisterConversion(new TablespoonOfFlourToKilograms());
    service.RegisterConversion(new TablespoonOfFlourToOunces());
    service.RegisterConversion(new TablespoonOfFlourToPounds());
    service.RegisterConversion(new TeaspoonOfFlourToGrams());
    service.RegisterConversion(new TeaspoonOfFlourToKilograms());
    service.RegisterConversion(new TeaspoonOfFlourToOunces());
    service.RegisterConversion(new TeaspoonOfFlourToPounds());
    service.RegisterConversion(new GramsToCupsOfFlour());
    service.RegisterConversion(new KilogramsToCupsOfFlour());
    service.RegisterConversion(new OuncesToCupsOfFlour());
    service.RegisterConversion(new PoundsToCupsOfFlour());
    service.RegisterConversion(new GramsToTablespoonsOfFlour());
    service.RegisterConversion(new KilogramsToTablespoonsOfFlour());
    service.RegisterConversion(new OuncesToTablespoonsOfFlour());
    service.RegisterConversion(new PoundsToTablespoonsOfFlour());
    service.RegisterConversion(new GramsToTeaspoonsOfFlour());
    service.RegisterConversion(new KilogramsToTeaspoonsOfFlour());
    service.RegisterConversion(new OuncesToTeaspoonsOfFlour());
    service.RegisterConversion(new PoundsToTeaspoonsOfFlour());

    // Butter Conversions
    service.RegisterConversion(new CupOfButterToGrams());
    service.RegisterConversion(new CupOfButterToKilograms());
    service.RegisterConversion(new CupOfButterToOunces());
    service.RegisterConversion(new CupOfButterToPounds());
    service.RegisterConversion(new TablespoonOfButterToGrams());
    service.RegisterConversion(new TablespoonOfButterToKilograms());
    service.RegisterConversion(new TablespoonOfButterToOunces());
    service.RegisterConversion(new TablespoonOfButterToPounds());
    service.RegisterConversion(new TeaspoonOfButterToGrams());
    service.RegisterConversion(new TeaspoonOfButterToKilograms());
    service.RegisterConversion(new TeaspoonOfButterToOunces());
    service.RegisterConversion(new TeaspoonOfButterToPounds());
    service.RegisterConversion(new GramsToCupsOfButter());
    service.RegisterConversion(new KilogramsToCupsOfButter());
    service.RegisterConversion(new OuncesToCupsOfButter());
    service.RegisterConversion(new PoundsToCupsOfButter());
    service.RegisterConversion(new GramsToTablespoonsOfButter());
    service.RegisterConversion(new KilogramsToTablespoonsOfButter());
    service.RegisterConversion(new OuncesToTablespoonsOfButter());
    service.RegisterConversion(new PoundsToTablespoonsOfButter());
    service.RegisterConversion(new GramsToTeaspoonsOfButter());
    service.RegisterConversion(new KilogramsToTeaspoonsOfButter());
    service.RegisterConversion(new OuncesToTeaspoonsOfButter());
    service.RegisterConversion(new PoundsToTeaspoonsOfButter());

    // Milk Conversions
    /*
    service.RegisterConversion(new CupOfMilkToGrams());
    service.RegisterConversion(new CupOfMilkToKilograms());
    service.RegisterConversion(new CupOfMilkToOunces());
    service.RegisterConversion(new CupOfMilkToPounds());
    service.RegisterConversion(new TablespoonOfMilkToGrams());
    service.RegisterConversion(new TablespoonOfMilkToKilograms());
    service.RegisterConversion(new TablespoonOfMilkToOunces());
    service.RegisterConversion(new TablespoonOfMilkToPounds());
    service.RegisterConversion(new TeaspoonOfMilkToGrams());
    service.RegisterConversion(new TeaspoonOfMilkToKilograms());
    service.RegisterConversion(new TeaspoonOfMilkToOunces());
    service.RegisterConversion(new TeaspoonOfMilkToPounds());*/
    service.RegisterConversion(new GramsToCupsOfMilk());
    service.RegisterConversion(new KilogramsToCupsOfMilk());
    service.RegisterConversion(new OuncesToCupsOfMilk());
    service.RegisterConversion(new PoundsToCupsOfMilk());
    service.RegisterConversion(new GramsToTablespoonsOfMilk());
    service.RegisterConversion(new KilogramsToTablespoonsOfMilk());
    service.RegisterConversion(new OuncesToTablespoonsOfMilk());
    service.RegisterConversion(new PoundsToTablespoonsOfMilk());
    service.RegisterConversion(new GramsToTeaspoonsOfMilk());
    service.RegisterConversion(new KilogramsToTeaspoonsOfMilk());
    service.RegisterConversion(new OuncesToTeaspoonsOfMilk());
    service.RegisterConversion(new PoundsToTeaspoonsOfMilk());

    // Rice Conversions
    service.RegisterConversion(new CupOfRiceToGrams());
    service.RegisterConversion(new CupOfRiceToKilograms());
    service.RegisterConversion(new CupOfRiceToOunces());
    service.RegisterConversion(new CupOfRiceToPounds());
    service.RegisterConversion(new TablespoonOfRiceToGrams());
    service.RegisterConversion(new TablespoonOfRiceToKilograms());
    service.RegisterConversion(new TablespoonOfRiceToOunces());
    service.RegisterConversion(new TablespoonOfRiceToPounds());
    service.RegisterConversion(new TeaspoonOfRiceToGrams());
    service.RegisterConversion(new TeaspoonOfRiceToKilograms());
    service.RegisterConversion(new TeaspoonOfRiceToOunces());
    service.RegisterConversion(new TeaspoonOfRiceToPounds());
    service.RegisterConversion(new GramsToCupsOfRice());
    service.RegisterConversion(new KilogramsToCupsOfRice());
    service.RegisterConversion(new OuncesToCupsOfRice());
    service.RegisterConversion(new PoundsToCupsOfRice());
    service.RegisterConversion(new GramsToTablespoonsOfRice());
    service.RegisterConversion(new KilogramsToTablespoonsOfRice());
    service.RegisterConversion(new OuncesToTablespoonsOfRice());
    service.RegisterConversion(new PoundsToTablespoonsOfRice());
    service.RegisterConversion(new GramsToTeaspoonsOfRice());
    service.RegisterConversion(new KilogramsToTeaspoonsOfRice());
    service.RegisterConversion(new OuncesToTeaspoonsOfRice());
    service.RegisterConversion(new PoundsToTeaspoonsOfRice());


    return service;
});



var host = builder.Build();

//Initialize TranslationService
var translationService = host.Services.GetRequiredService<TranslationService>();
await translationService.InitializeAsync();

await host.RunAsync();

await builder.Build().RunAsync();
