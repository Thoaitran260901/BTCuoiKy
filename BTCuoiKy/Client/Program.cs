global using BTCuoiKy.Client.Services.GameServices;
global using BTCuoiKy.Client.Services.SinhvienServices;
global using BTCuoiKy.Client.Services.ExcelServices;
global using BTCuoiKy.Shared.Models;
global using BTCuoiKy.Shared;
global using System.Net.Http.Json;
using BTCuoiKy.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IGameServices, GameServices>();
builder.Services.AddScoped<ISinhvienService, SinhvienService>();
builder.Services.AddScoped<IExcelService, ExcelService>();

await builder.Build().RunAsync();
