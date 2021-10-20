using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramBot
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("2073841951:AAEwv5BcSBbG3X1VGyzkV-0dtjrCTVBWxqk");
        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_OnMessage;
            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();

        }
        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                if (e.Message.Text == "Hy")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Hello from Bot");
                }

            }
        }
    }
}
