using LogInTask;
using LogInTask.Services;
using LogInTask.Models;
using LogInTask.Validators;
using FluentValidation;
using LogInTask.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IElectricMeterService, ElectricMeterService>();

builder.Services.AddScoped<IValidator<MeterQueryRequest>, MeterQueryRequestValidator>();

builder.Services.AddScoped<HttpClient>();
builder.Services.AddScoped<IValidator<MeterQueryRequest>, MeterQueryRequestValidator>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
