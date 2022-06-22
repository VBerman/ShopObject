using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using ShopObject;
using ShopObject.Model;
using ShopObject.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddDbContextFactory<ShopObjectContext>(
    options =>
        options.UseSqlServer("Server=localhost;Database=ShopObject;Trusted_Connection=True;")
    );
builder.Services.AddDbContext<ShopObjectContext>(
    options =>
        options.UseSqlServer("Server=localhost;Database=ShopObject;Trusted_Connection=True;")
    );

builder.Services.AddScoped<ClientService>();
await builder.Build().RunAsync();
