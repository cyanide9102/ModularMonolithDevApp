using System.Runtime.CompilerServices;

using Microsoft.Extensions.DependencyInjection;

using ModularMonolithDevApp.Shared.Infrastructure.Api;

[assembly: InternalsVisibleTo("ModularMonolithDevApp.Bootstrapper")]
namespace ModularMonolithDevApp.Shared.Infrastructure;

internal static class Infrastructure
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddControllers()
                .ConfigureApplicationPartManager(manager => manager.FeatureProviders.Add(new InternalControllerFeatureProvider()));

        return services;
    }
}
