using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace Breez;

public sealed class BreezResourceOptions : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest = new();

    static BreezResourceOptions()
    {
        _manifest
            .DefineStyle("Breez")
            .SetUrl("~/Breez/css/site.css")
            .SetVersion("1.0.0");
    }

    public void Configure(ResourceManagementOptions options)
        => options.ResourceManifests.Add(_manifest);
}
