using Application;
using WebApi;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddWebApi();
builder.Services.AddApplication(builder.Configuration);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/quran/{surah}/{ayah}",
    (int surah,
        int ayah) => Quran.Surahs.Skip(surah - 1)
        .First()
        .Verses.Skip(ayah - 1)
        .First());
app.Run();