using Application;

namespace WebApi;

public static class  DependencyInjection
{
    public static IServiceCollection AddWebApi(this IServiceCollection services)
    {
        services.AddApplication();
        return services;
    }
}