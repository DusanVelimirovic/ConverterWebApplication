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
    service.RegisterConversion(new KilometersToMeters());
    service.RegisterConversion(new MetersToMiles());
    service.RegisterConversion(new MilesToMeters());
    service.RegisterConversion(new MetersToCentimeters());
    service.RegisterConversion(new CentimetersToMeters());
    service.RegisterConversion(new MillimetersToMeters());
    service.RegisterConversion(new MetersToMillimeters());
    service.RegisterConversion(new MilesToKilometers());
    service.RegisterConversion(new KilometersToMiles());
    service.RegisterConversion(new MetersToFeet());
    service.RegisterConversion(new FeetToMeters());
    service.RegisterConversion(new InchesToCentimeters());
    service.RegisterConversion(new CentimetersToInches());
    service.RegisterConversion(new MetersToYards());
    service.RegisterConversion(new YardsToMeters());
    service.RegisterConversion(new KilometersToNauticalMiles());
    service.RegisterConversion(new NauticalMilesToKilometers());
    service.RegisterConversion(new KilometersToLeagues());
    service.RegisterConversion(new LeaguesToKilometers());

    // Add more conversions here if needed
    return service;
});

await builder.Build().RunAsync();
