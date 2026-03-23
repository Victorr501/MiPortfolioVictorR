using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MiPortfolioVictorR.Client;
using MiPortfolioVictorR.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


builder.Services.AddScoped<ProjectService>();
builder.Services.AddScoped<ExperienceService>();
builder.Services.AddScoped<EducationService>();
builder.Services.AddScoped<SkillService>();
builder.Services.AddScoped<TrackifyService>();
builder.Services.AddScoped<ContactService>();
builder.Services.AddScoped<ChallengeMeService>();

await builder.Build().RunAsync();
