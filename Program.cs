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
    // Register conversions
    service.RegisterConversion(new MetersToKilometers());

    service.RegisterConversion(new MetersToMiles());

    service.RegisterConversion(new MetersToCentimeters());
    service.RegisterConversion(new CentimetersToMeters());

    service.RegisterConversion(new MetersToMillimeters());


    service.RegisterConversion(new MetersToFeet());
    service.RegisterConversion(new FeetToMeters());
    service.RegisterConversion(new InchesToCentimeters());

    service.RegisterConversion(new MetersToYards());
    service.RegisterConversion(new YardsToMeters());

    service.RegisterConversion(new NauticalMilesToKilometers());

    service.RegisterConversion(new LeaguesToKilometers());

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

    // Centimeters
    service.RegisterConversion(new CentimetersToInches());
    service.RegisterConversion(new CentimetersToKilometers());
    service.RegisterConversion(new CentimetersToMiles());
    service.RegisterConversion(new CentimetersToMillimeters());
    service.RegisterConversion(new CentimetersToNauticalMiles());
    service.RegisterConversion(new CentimetersToYards());
    service.RegisterConversion(new CentimetersToFeet());

    // Millimeters
    service.RegisterConversion(new MillimetersToMeters());
    service.RegisterConversion(new MillimetersToKilometers());
    service.RegisterConversion(new MillimetersToMiles());
    service.RegisterConversion(new MillimetersToCentimeters());
    service.RegisterConversion(new MillimetersToYards());
    service.RegisterConversion(new MillimetersToFeet());
    service.RegisterConversion(new MillimetersToNauticalMiles());


    // Add more conversions here if needed
    return service;
});

await builder.Build().RunAsync();
