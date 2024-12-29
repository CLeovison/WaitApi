using System.Reflection;
using Microsoft.Extensions.DependencyInjection.Extensions;


public static class EndpointExtension
{
    public static IServiceCollection AddEndpoint(this IServiceCollection services, Assembly assembly)
    {
        ServiceDescriptor[] endpointServiceDescriptor = assembly.DefinedTypes
        .Where(type => type is { IsAbstract: false, IsInterface: false } && type.IsAssignableFrom(typeof(IEndpoint)))
        .Select(type => ServiceDescriptor.Transient(typeof(IEndpoint),type))
        .ToArray();

        services.TryAddEnumerable(endpointServiceDescriptor);
        return services;
    }
}