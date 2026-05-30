using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;

namespace Breez;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
        => services.AddTransient<IConfigureOptions<ResourceManagementOptions>,
                                 BreezResourceOptions>();
}
