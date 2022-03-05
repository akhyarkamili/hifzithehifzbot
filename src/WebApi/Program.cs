using Hifzi;

var builder = WebApplication.CreateBuilder(args);

var quranSingleton = new Quran();
builder.Services.AddSingleton(quranSingleton);

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();