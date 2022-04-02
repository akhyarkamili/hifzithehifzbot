using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;

namespace WebApi;

public class BotManager
{
    private readonly CancellationTokenSource _cts;
    private static TelegramBotClient? _bot;
    private readonly IConfiguration _configuration;

    public BotManager(IConfiguration configuration)
    {
        _configuration = configuration;
        _cts = new CancellationTokenSource();
    }
   
    public async Task Start()
    {
        _bot = new TelegramBotClient(_configuration.GetValue<string>("BotKey"));
        User me = await _bot.GetMeAsync();

        using var cts = new CancellationTokenSource();

        // StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
        ReceiverOptions receiverOptions = new() { AllowedUpdates = { } };
        _bot.StartReceiving(Handlers.HandleUpdateAsync, Handlers.HandleErrorAsync, receiverOptions, _cts.Token);
    }

    public void Stop()
    {
        _cts.Cancel();
    }
}