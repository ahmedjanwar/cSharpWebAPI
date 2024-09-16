using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorApp1;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components.Web;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register ProductService
builder.Services.AddScoped<ProductService>();

// Set the base address for the Web API (replace with actual API URL)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5100/api/") });

await builder.Build().RunAsync();
