using System.Runtime.CompilerServices;

using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("ModularMonolithDevApp.Bootstrapper")]
namespace ModularMonolithDevApp.Modules.Confrences.Api;

internal static class ConfrencesModule
{
    public static IServiceCollection AddConfrencesModule(this IServiceCollection services)
    {
        return services;
    }
}
