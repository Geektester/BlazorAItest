using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using test1;
using test1.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Logging.SetMinimumLevel(LogLevel.Debug);
AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
{
    Console.WriteLine($"Unhandled exception: {e.ExceptionObject}");
};
builder.Services.AddSingleton<SessionState>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddSingleton<AttendanceService>();

await builder.Build().RunAsync();

