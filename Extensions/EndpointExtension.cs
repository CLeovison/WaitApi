using System.Reflection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using WaitApi.Abstract;

namespace WaitApi.Extensions;
public static class EndpointExtension
{
    public static IServiceCollection AddEndpoint(this IServiceCollection services, Assembly assembly)
    {
        ServiceDescriptor[] serviceDescriptor = assembly.DefinedTypes
        .Where(type => type is { IsAbstract: false, IsInterface: false } && type.IsAssignableTo(typeof(IEndpoint)))
        .Select(type => ServiceDescriptor.Transient(typeof(IEndpoint), type))
        .ToArray();

        services.TryAddEnumerable(serviceDescriptor); 
        return services;
    }



    
}