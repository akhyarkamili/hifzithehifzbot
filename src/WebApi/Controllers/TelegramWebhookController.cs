using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;

namespace WebApi.Controllers;

[Route("[controller]")]
public class TelegramWebhookController : ControllerBase
{
    // GET
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var botClient = new TelegramBotClient("5176569938:AAGQir39LfZajpCB2e-WE1iM9uRNaMcxT3w");

        var me = await botClient.GetMeAsync();

        return Ok($"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");
    }
}