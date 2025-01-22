namespace eNovaSoft.Web.Core.Infrastructure.Extensions;
public static class BuilderExtensions
{
    public static void AddInfrastructure(this WebAssemblyHostBuilder builder)
    {
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
    }
}
