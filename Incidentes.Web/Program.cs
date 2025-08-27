using Incidentes.Web;
using Incidentes.Web.Interfaces;
using Incidentes.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

// Leer la URL base de la API desde appsettings.json
var apiBaseUrl = builder.Configuration["ApiBaseUrl"];
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl) });

builder.Services.AddScoped<IImpactoService, ImpactoService>();
builder.Services.AddScoped<IPrioridadService, PrioridadService>();
builder.Services.AddScoped<ITipoIncidenteService, TipoIncidenteService>();
builder.Services.AddScoped<IIncidenteService, IncidenteService>();

await builder.Build().RunAsync();
