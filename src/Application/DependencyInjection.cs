using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        var quranUrl = configuration.GetSection("QuranUrl").Value;
        var quranSingleton = new Quran(quranUrl);
        services.AddSingleton(quranSingleton);
        
        return services;
    }
}