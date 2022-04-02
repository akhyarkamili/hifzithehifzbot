using Application;
using Newtonsoft.Json;
using Serilog;

namespace WebApi;

public static class DefineControllersExtension
{
    public static void DefineControllers(this WebApplication app)
    {
        app.MapGet("/", () => "Hello World!");
        app.MapGet("/quran/{surah}/{ayah}",
            (int surah,
                int ayah) => JsonConvert.SerializeObject(Quran.Surahs.Skip(surah - 1)
                .First()
                .Verses.Skip(ayah - 1)
                .First()));
        
        app.MapPost("/StartReceiving", async (BotManager manager) =>
        {
            Log.Information("Start receiving called!");
            await manager.Start();
        });
        app.MapPost("/StopReceiving", (BotManager manager) =>
        {
            Log.Information("Stop receiving called!");
            manager.Stop();
        });
    }
}