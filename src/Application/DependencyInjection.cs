using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var quranSingleton = new Quran();
        services.AddSingleton(quranSingleton);
        
        return services;
    }
}