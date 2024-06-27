using Converter_Web_Application;
using Converter_Web_Application.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

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


    // Square feet
    service.RegisterConversion(new SquareFeetToSquereMeters());
    service.RegisterConversion(new SquareFeetToSquereYards());
    service.RegisterConversion(new SquareFeetToSquereMiles());
    service.RegisterConversion(new SquareFeetToSquereKilometers());
    service.RegisterConversion(new SquareFeetToAcres());
    service.RegisterConversion(new SquareFeetToHectares());

    // Square yards
    service.RegisterConversion(new SquareYardsToSquareMeters());
    service.RegisterConversion(new SquareYardsToSquareFeet());
    service.RegisterConversion(new SquareYardsToSquareMiles());
    service.RegisterConversion(new SquareYardsToSquareKilometers());
    service.RegisterConversion(new SquareYardsToAcres());
    service.RegisterConversion(new SquareYardsToHectares());

    // Square miles
    service.RegisterConversion(new SquareMilesToSquereMeters());
    service.RegisterConversion(new SquareMilesToSquereFeet());
    service.RegisterConversion(new SquareMilesToSquereYards());
    service.RegisterConversion(new SquareMilesToSquereKilometers());
    service.RegisterConversion(new SquareMilesToAcres());
    service.RegisterConversion(new SquareMilesToHectares());

    // Square kilometers
    service.RegisterConversion(new SquareKilometersToSquereMeters());
    service.RegisterConversion(new SquareKilometersToSquereFeet());
    service.RegisterConversion(new SquareKilometersToSquereYards());
    service.RegisterConversion(new SquareKilometersToSquereMiles());
    service.RegisterConversion(new SquareKilometersToAcres());
    service.RegisterConversion(new SquareKilometersToHectares());

    // Acres
    service.RegisterConversion(new AcresToMeters());
    service.RegisterConversion(new AcresToSquereFeet());
    service.RegisterConversion(new AcresToSquereYards());
    service.RegisterConversion(new AcresToSquereMiles());
    service.RegisterConversion(new AcresToSquereKilometers());
    service.RegisterConversion(new AcresToHectares());

    // Hectares
    service.RegisterConversion(new HectaresToSquereMeters());
    service.RegisterConversion(new HectaresToSquereFeet());
    service.RegisterConversion(new HectaresToSquereYards());
    service.RegisterConversion(new HectaresToSquereMiles());
    service.RegisterConversion(new HectaresToSquereKilometers());
    service.RegisterConversion(new HectaresToAcres());

    // Square centimeters
    service.RegisterConversion(new SquereCentimetersToSquereInches());
    service.RegisterConversion(new SquereCentimetersToSquereMillimeters());

    // Square inches
    service.RegisterConversion(new SquereInchesToSquereCentimeters());
    service.RegisterConversion(new SquereInchesToSquereMillimeters());

    // Square millimeters
    service.RegisterConversion(new SquereMillimetersToSquereInches());
    service.RegisterConversion(new SquereMillimetersToSquereCentimeters());







    // Add more conversions here if needed
    return service;
});

await builder.Build().RunAsync();
