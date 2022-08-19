using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using IgniteUI.Blazor.Controls;
using TeamCollaboration8;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
        typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
        typeof(IgniteUI.Blazor.Controls.IgbDropdownModule),
        typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
        typeof(IgniteUI.Blazor.Controls.IgbDropdownHeaderModule),
        typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
        typeof(IgniteUI.Blazor.Controls.IgbNavDrawerModule),
        typeof(IgniteUI.Blazor.Controls.IgbBadgeModule),
        typeof(IgniteUI.Blazor.Controls.IgbListModule),
        typeof(IgniteUI.Blazor.Controls.IgbCalendarModule),
        typeof(IgniteUI.Blazor.Controls.IgbCardModule)
    );
}