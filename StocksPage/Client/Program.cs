using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StocksPage.Client.Services;
using StocksPage.Client;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("SyncfusionLicense");

builder.Services.AddHttpClient<IHttpStockService, HttpStockService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient("StocksPage.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("StocksPage.ServerAPI"));
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
