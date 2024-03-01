using KiotaMovies.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Movies_BlazorWASM;
using Movies_BlazorWASM.Data;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddDbContext<MoviesDbContext>(options =>
    options.UseInMemoryDatabase("Movies"));

builder.Services.AddScoped((sp) =>
{
    var authprovider = new AnonymousAuthenticationProvider();
    var adapter = new HttpClientRequestAdapter(authprovider,httpClient:new HttpClient() { BaseAddress = new Uri("https://localhost:7254/") });
    return new MoviesClient(adapter);

});



builder.Services.AddOidcAuthentication(options =>
{
    // Configure your authentication provider options here.
    // For more information, see https://aka.ms/blazor-standalone-auth
    builder.Configuration.Bind("Local", options.ProviderOptions);
});

await builder.Build().RunAsync();
