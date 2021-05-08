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
            Console.WriteLine(Environment.NewLine + "Veuillez saisir votre token [BOT] (Bientôt une version User)" + Environment.NewLine, System.Drawing.Color.HotPink);

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
            return Task.CompletedTask;
        }

        private async static Task<Task> ReadyApp()
        {
            Console.Clear();
            Console.Title = "Discord Kira-Tool";
            Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
            Console.WriteLine("By Seryû : https://github.com/Seryu-Ub" + Environment.NewLine, System.Drawing.Color.DeepPink);
            Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
            Console.WriteLine("Connecté sur l'utilisateur : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
            Console.WriteLine("--------------------------------------" + Environment.NewLine, System.Drawing.Color.MediumPurple);
            Console.WriteLine("[1] Twitch Presence   #####   [2] Playing Presence   ####   [3] Watching Presence   ####   [4] Listening Presence" + Environment.NewLine, System.Drawing.Color.HotPink);
            Console.WriteLine("[5] Envoyer un message   #####   [6] Envoyer un embed   ####   [7] Bannir un utilisateur   ####   [8] Débannir un utilisateur" + Environment.NewLine, System.Drawing.Color.HotPink);


            string up = Console.ReadLine();

            if (up == "1")
            {
                Console.Clear();
                Console.Title = "Discord Kira-Tool | Twitch Presence";
                Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
                Console.WriteLine("By Seryû : https://github.com/Seryu-Ub" + Environment.NewLine, System.Drawing.Color.DeepPink);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine("Connecté sur l'utilisateur : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
                Console.WriteLine("--------------------------------------" + Environment.NewLine, System.Drawing.Color.MediumPurple);
                Console.WriteLine("Si vous voulez supprimer votre présence il suffit de ne rien écrire et de presser \"Entrée\"" + Environment.NewLine, System.Drawing.Color.Cyan);
                Console.WriteLine("Veuillez saisir le message de votre présence :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string rpc = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + "Veuillez saisir votre lien twitch :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string link = Console.ReadLine();

                await _client.SetGameAsync(rpc, link, ActivityType.Streaming);

                Console.WriteLine(Environment.NewLine + "Votre présence a été changé avec succès !" + Environment.NewLine, System.Drawing.Color.MediumPurple);

                await Task.Delay(4000);

                await Program.ReadyApp();
            }

            if (up == "2")
            {
                Console.Clear();
                Console.Title = "Discord Kira-Tool | Playing Presence";
                Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
                Console.WriteLine("By Seryû : https://github.com/Seryu-Ub" + Environment.NewLine, System.Drawing.Color.DeepPink);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine("Connecté sur l'utilisateur : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
                Console.WriteLine("--------------------------------------" + Environment.NewLine, System.Drawing.Color.MediumPurple);
                Console.WriteLine("Si vous voulez supprimer votre présence il suffit de ne rien écrire et de presser \"Entrée\"" + Environment.NewLine, System.Drawing.Color.Cyan);
                Console.WriteLine("Veuillez saisir le message de votre présence :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string rpc = Console.ReadLine();

                await _client.SetActivityAsync(new Game(rpc, ActivityType.Playing));

                Console.WriteLine(Environment.NewLine + "Votre présence a été changé avec succès !" + Environment.NewLine, System.Drawing.Color.MediumPurple);

                await Task.Delay(4000);

                await Program.ReadyApp();
            }

            if (up == "3")
            {
                Console.Clear();
                Console.Title = "Discord Kira-Tool | Watching Presence";
                Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
                Console.WriteLine("By Seryû : https://github.com/Seryu-Ub" + Environment.NewLine, System.Drawing.Color.DeepPink);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine("Connecté sur l'utilisateur : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine("Si vous voulez supprimer votre présence il suffit de ne rien écrire et de presser \"Entrée\"" + Environment.NewLine, System.Drawing.Color.Cyan);
                Console.WriteLine("Veuillez saisir le message de votre présence :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string rpc = Console.ReadLine();

                await _client.SetActivityAsync(new Game(rpc, ActivityType.Watching));

                Console.WriteLine(Environment.NewLine + "Votre présence a été changé avec succès !" + Environment.NewLine, System.Drawing.Color.MediumPurple);

                await Task.Delay(4000);

                await Program.ReadyApp();
            }

            if (up == "4")
            {
                Console.Clear();
                Console.Title = "Discord Kira-Tool | Listening Presence";
                Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
                Console.WriteLine("By Seryû : https://github.com/Seryu-Ub" + Environment.NewLine, System.Drawing.Color.DeepPink);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine("Connecté sur l'utilisateur : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
                Console.WriteLine("--------------------------------------" + Environment.NewLine, System.Drawing.Color.MediumPurple);
                Console.WriteLine("Si vous voulez supprimer votre présence il suffit de ne rien écrire et de presser \"Entrée\"" + Environment.NewLine, System.Drawing.Color.Cyan);
                Console.WriteLine("Veuillez saisir le message de votre présence :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string rpc = Console.ReadLine();

                await _client.SetActivityAsync(new Game(rpc, ActivityType.Listening));

                Console.WriteLine(Environment.NewLine + "Votre présence a été changé avec succès !" + Environment.NewLine, System.Drawing.Color.MediumPurple);

                await Task.Delay(4000);

                await Program.ReadyApp();
            }

            if (up == "5")
            {
                Console.Clear();
                Console.Title = "Discord Kira-Tool | Envoyer un message";
                Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
                Console.WriteLine("By Seryû : https://github.com/Seryu-Ub" + Environment.NewLine, System.Drawing.Color.DeepPink);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine("Connecté sur l'utilisateur : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
                Console.WriteLine("--------------------------------------" + Environment.NewLine, System.Drawing.Color.MediumPurple);
                Console.WriteLine("Veuillez saisir votre message à envoyer :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string message = "";
                message = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + "Veuillez saisir l'id du channel où envoyer le message :" + Environment.NewLine);
                ulong channel = ulong.Parse(Console.ReadLine());

                var chnl = _client.GetChannel(channel) as IMessageChannel;
                await chnl.SendMessageAsync(message);

                Console.WriteLine(Environment.NewLine + "Votre message a bien été envoyer !" + Environment.NewLine, System.Drawing.Color.MediumPurple);

                await Task.Delay(4000);

                await Program.ReadyApp();
            }

            if (up == "6")
            {
                Console.Clear();
                Console.Title = "Discord Kira-Tool | Envoyer un embed";
                Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
                Console.WriteLine("By Seryû : https://github.com/Seryu-Ub" + Environment.NewLine, System.Drawing.Color.DeepPink);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine("Connecté sur l'utilisateur : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
                Console.WriteLine("--------------------------------------" + Environment.NewLine, System.Drawing.Color.MediumPurple);
                Console.WriteLine("Veuillez saisir l'id du channel où envoyer le message :" + Environment.NewLine, System.Drawing.Color.Cyan);
                ulong channel = ulong.Parse(Console.ReadLine());
                var chnl = _client.GetChannel(channel) as IMessageChannel;
                Console.WriteLine(Environment.NewLine + "Veuillez saisir un titre à l'embed (si vous ne voulez pas en mettre il suffit de ne rien écrire et de presser \"Entrée\") :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string titre = "";
                titre = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + "Veuillez saisir la description de l'embed (si vous ne voulez pas en mettre il suffit de ne rien écrire et de presser \"Entrée\") :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string message = "";
                message = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + "Veuillez saisir l'image de l'embed (si vous ne voulez pas en mettre il suffit de ne rien écrire et de presser \"Entrée\") :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string image = "";
                image = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + "Veuillez saisir le thumbnail de l'embed (si vous ne voulez pas en mettre il suffit de ne rien écrire et de presser \"Entrée\") :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string thumbnail = "";
                thumbnail = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + "Veuillez saisir le footer de l'embed (si vous ne voulez pas en mettre il suffit de ne rien écrire et de presser \"Entrée\") :" + Environment.NewLine, System.Drawing.Color.Cyan);
                string footer = "";
                footer = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + "Couleur de l'embed [RGB] :" + Environment.NewLine, System.Drawing.Color.Cyan);
                byte r = byte.Parse(Console.ReadLine());
                Console.WriteLine(Environment.NewLine + "Couleur de l'embed [RGB] :" + Environment.NewLine, System.Drawing.Color.Cyan);
                byte g = byte.Parse(Console.ReadLine());
                Console.WriteLine(Environment.NewLine + "Couleur de l'embed [RGB] :" + Environment.NewLine, System.Drawing.Color.Cyan);
                byte b = byte.Parse(Console.ReadLine());
                Console.WriteLine(Environment.NewLine + "Voulez vous activer le timestamp ? [Oui / Non] (Majuscule à la 1er lettre)" + Environment.NewLine, System.Drawing.Color.Cyan);
                string oi = Console.ReadLine();
                if (oi == "Oui")
                {
                    var builder = new EmbedBuilder()
                        .WithTitle(titre)
                        .WithDescription(message)
                        .WithImageUrl(image)
                        .WithThumbnailUrl(thumbnail)
                        .WithColor(new Color(r, g, b))
                        .WithFooter(footer)
                        .WithCurrentTimestamp();
                    var embed = builder.Build();
                    await chnl.SendMessageAsync(null, false, embed);
                }
                if (oi == "Non")
                {
                    var builder = new EmbedBuilder()
                        .WithTitle(titre)
                        .WithDescription(message)
                        .WithImageUrl(image)
                        .WithThumbnailUrl(thumbnail)
                        .WithColor(new Color(r, g, b))
                        .WithFooter(footer);
                    var embed = builder.Build();
                    await chnl.SendMessageAsync(null, false, embed);
                }

                Console.WriteLine(Environment.NewLine + "Votre embed a bien été envoyer !" + Environment.NewLine, System.Drawing.Color.MediumPurple);

                await Task.Delay(4000);

                await Program.ReadyApp();
            }

            if (up == "7")
            {
                Console.Clear();
                Console.Title = "Discord Kira-Tool | Bannir un utilisateur";
                Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
                Console.WriteLine("By Seryû : https://github.com/Seryu-Ub" + Environment.NewLine, System.Drawing.Color.DeepPink);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine("Connecté sur l'utilisateur : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine(Environment.NewLine + "[Vous (ou votre bot) devez avoir la permission de gerer les bannissements]" + Environment.NewLine, System.Drawing.Color.MediumPurple);
                Console.WriteLine("Veuillez saisir l'id du serveur ou ce trouve la personne que vous voulez bannir :" + Environment.NewLine, System.Drawing.Color.Cyan);
                ulong serv = ulong.Parse(Console.ReadLine());
                Console.WriteLine(Environment.NewLine + "Veuillez saisir l'id de la personne que vous voulez bannir :" + Environment.NewLine, System.Drawing.Color.Cyan);
                ulong iduser = ulong.Parse(Console.ReadLine());
                SocketGuild guild = _client.GetGuild(serv);

                foreach (SocketUser user in guild.Users)
                {
                    try
                    {
                        await guild.AddBanAsync(iduser, 0, "Discord Kira-Tool");

                    }
                    catch (Exception)
                    {
                        Console.WriteLine(Environment.NewLine + "Une erreur est survenue. Nous allons vous remettre sur la page principale.", System.Drawing.Color.Red);
                        await Task.Delay(4000);
                        return await Program.ReadyApp();
                    }
                }

                Console.WriteLine(Environment.NewLine + "L'utilisateur a bien été banni !" + Environment.NewLine, System.Drawing.Color.MediumPurple);

                await Task.Delay(4000);

                await Program.ReadyApp();
            }

            if (up == "8")
            {
                Console.Clear();
                Console.Title = "Discord Kira-Tool | Débannir un utilisateur";
                Console.WriteAscii("Discord Kira-Tool V.1", System.Drawing.Color.DeepPink);
                Console.WriteLine("By Seryû : https://github.com/Seryu-Ub" + Environment.NewLine, System.Drawing.Color.DeepPink);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine("Connecté sur l'utilisateur : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator, System.Drawing.Color.MediumPurple);
                Console.WriteLine("--------------------------------------", System.Drawing.Color.MediumPurple);
                Console.WriteLine(Environment.NewLine + "[Vous (ou votre bot) devez avoir la permission de gerer les bannissements]" + Environment.NewLine, System.Drawing.Color.MediumPurple);
                Console.WriteLine("Veuillez saisir l'id du serveur ou ce trouve la personne que vous voulez débannir :" + Environment.NewLine, System.Drawing.Color.Cyan);
                ulong serv = ulong.Parse(Console.ReadLine());
                Console.WriteLine(Environment.NewLine + "Veuillez saisir l'id de la personne que vous voulez débannir :" + Environment.NewLine, System.Drawing.Color.Cyan);
                ulong iduser = ulong.Parse(Console.ReadLine());
                SocketGuild guild = _client.GetGuild(serv);

                foreach (SocketUser user in guild.Users)
                {
                    try
                    {
                        await guild.RemoveBanAsync(iduser);

                    }
                    catch (Exception)
                    {
                        Console.WriteLine(Environment.NewLine + "Une erreur est survenue. Nous allons vous remettre sur la page principale.", System.Drawing.Color.Red);
                        await Task.Delay(4000);
                        return await Program.ReadyApp();
                    }
                }

                Console.WriteLine(Environment.NewLine + "L'utilisateur a bien été débanni !" + Environment.NewLine, System.Drawing.Color.MediumPurple);

                await Task.Delay(4000);

                await Program.ReadyApp();
            }
            return Task.CompletedTask;
        }
    }
}
