using System;
using System.Threading.Tasks;
using Console = Colorful.Console;
using Discord;
using Discord.WebSocket;

namespace Kira_Tool
{
    class Program
    {
        private static DiscordSocketClient _client;

        static void Main(string[] args)
        {
            Console.SetWindowSize(132, 30);
            Console.Title = "Discord Kira-Tool";
            string user = "";
            Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
            Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
            Console.WriteLine("By Seryû : https://github.com/Seryu-Ub", System.Drawing.Color.MediumPurple);
            Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
            Console.WriteLine(Environment.NewLine + "Veuillez saisir votre token [BOT / USER]" + Environment.NewLine, System.Drawing.Color.HotPink);

            user = Console.ReadLine();
            _client = new DiscordSocketClient();
            _client.Log += _client_Log;
            _client.LoginAsync(TokenType.Bot, user);
            _client.Ready += ReadyApp;
            _client.StartAsync();
            Task.Delay(-1).Wait();
        }

        private static Task _client_Log(LogMessage arg)
        {
            Console.WriteLine(Environment.NewLine + arg, System.Drawing.Color.DarkCyan);
            Console.Clear();
            return Task.CompletedTask;
        }

        private async static Task<Task> ReadyApp()
        {
            Console.Clear();
            Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
            Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
            Console.WriteLine("Connecté sur l'utilisateur :" + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
            Console.WriteLine("--------------------------------------" + Environment.NewLine, System.Drawing.Color.MediumPurple);
            Console.WriteLine("[1] Twitch Presence");

            string up = Console.ReadLine();

            if (up == "1")
            {
                Console.Clear();
                Console.Title = "Discord Kira-Tool | Twitch Presence";
                Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine("Connecté sur l'utilisateur :" + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
                Console.WriteLine("--------------------------------------" + Environment.NewLine, System.Drawing.Color.MediumPurple);
                Console.WriteLine("Veuillez saisir le message de votre présence :" + Environment.NewLine);
                string rpc = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + "Veuillez saisir votre lien twitch :" + Environment.NewLine);
                string link = Console.ReadLine();

                await _client.SetGameAsync(rpc, link, ActivityType.Streaming);

                await Program.ReadyApp();


            }
            return Task.CompletedTask;
        }
    }
}
