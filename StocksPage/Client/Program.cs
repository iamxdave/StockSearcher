using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StocksPage.Client;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHFqVVhkW1pFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF9jT39ad0dgWH5ecXZdQw==;Mgo+DSMBPh8sVXJ0S0d+XE9AcVRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3xTcERqWH1dcXVVR2RcVA==;ORg4AjUWIQA/Gnt2VVhhQlFaclhJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRdkNiUH5cc3VURmFZUEE=;NjU4NjQ0QDMyMzAyZTMxMmUzMFpWVkJNR2xncXBQa3BPVTFEdVhNRXNLRWt0RHNyODR2ZnYwbUZNbkdIUmM9;NjU4NjQ1QDMyMzAyZTMxMmUzMFRYN3RLNlBKRkEwa3B3OWFtVDZPWDc0L2Y1WlV4VGRqN1RuSWIwMXNHY2c9;NRAiBiAaIQQuGjN/V0Z+XU9EaFtFVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdEVlWHZfcndUR2BeV0Vw;NjU4NjQ3QDMyMzAyZTMxMmUzMExBbGpROUh0VHJ5RFZIWDIrN3F3L0Y2WTlUVkE3UVkrQ1pHbE11d2tUUUE9;NjU4NjQ4QDMyMzAyZTMxMmUzMFoyeTc3SjFnS2Q0NFdaQklWUEdGZXV6RnF2RVBKenNXL3dUQXZMUDdjSHM9;Mgo+DSMBMAY9C3t2VVhhQlFaclhJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRdkNiUH5cc3VURmNeUkI=;NjU4NjUwQDMyMzAyZTMxMmUzMGYwOXJWa2NESTRlV1pEYkR1NjlkNUpZc1hZYmFTeTNwZmdCWnd2cnF3cEE9;NjU4NjUxQDMyMzAyZTMxMmUzMEpXVTc0VGlnQTdIc2NoU3ZrWFNYREI0UDZ6elVkZWlRNU52TllGbllWQTQ9");

builder.Services.AddHttpClient("StocksPage.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
	.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("StocksPage.ServerAPI"));
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
