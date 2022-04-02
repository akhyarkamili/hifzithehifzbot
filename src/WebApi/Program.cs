using System.Diagnostics;
using Application;
using Serilog;
using WebApi;

var builder = WebApplication.CreateBuilder(args);
Serilog.Debugging.SelfLog.Enable(x => Debug.WriteLine(x));
builder.Host.UseSerilog((context, configuration) =>
{
        configuration.ReadFrom.Configuration(builder.Configuration);
});

builder.Services.AddApplication(builder.Configuration);
builder.Services.AddWebApi(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.DefineControllers();

app.UseSwagger();
app.UseSwaggerUI();

Log.Information("Starting Hifzi The Hifz Bot!");
app.Run();