using BlazorInjectBindModelApp.Components;
using BlazorInjectBindModelApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<ITimeService, TimeService>();
builder.Services.AddTransient<ITimeFormatter, TimeFormatter>();

var app = builder.Build();

app.UseStatusCodePagesWithReExecute("/404");


app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
