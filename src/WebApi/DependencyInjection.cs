using Application;

namespace WebApi;

public static class  DependencyInjection
{
    public static IServiceCollection AddWebApi(this IServiceCollection services, IConfiguration configuration)
    {
        var quranUrl = configuration.GetSection("QuranUrl").Value ?? "";
        HttpClient client = new HttpClient();
        var quranSingleton = new Quran(quranUrl, client);
        services.AddSingleton(quranSingleton);

        services.AddSwaggerGen();
        services.AddControllers();
        
        return services;
    }
}