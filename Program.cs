using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;


namespace TelegramBotExperiments
{

    class Program
    {


        static ITelegramBotClient bot = new TelegramBotClient("5716803316:AAE6z2opAVKRMf8JKwZqc7GQ_xn6zlSHvnE");
        public static bool _isActive = true;
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {

            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));

            try
            {
                if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
                {
                    var message = update.Message;

                    if (message != null && message.Text != null && message.Text.ToLower() == "базука команды" && _isActive)
                    {
                        await botClient.SendTextMessageAsync(message.Chat, "АТАТАТАТАТАТАТАТАТА!\n\nСписок команд:\nБазука кто я – узнать кто ты сегодня\n\nБазука завали ебало – потушить Базуку\n\nБазука голос – включить Базуку\n\nБазука помоги – рабочий совет от Базуки\n\nБазука кто добрый – узнать кто сегодня добрый, а кто нет");
                        _isActive = true;
                        return;
                    }
                }


                if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message && _isActive)
                {

                    var message = update.Message;
                    var chatId = message.Chat.Id;
                    var reply = message.MessageId;
                    Random rand = new Random();
                    int randomizer = rand.Next(1, 31);
                    string[] caption = {
                    "Сегодня ты клубная Базука!",
                    "Сегодня ты мощная Базука!",
                    "Сегодня ты мобилизованная Базука!",
                    "Сегодня ты квадратная Базука!",
                    "Сегодня ты удивленная Базука!",
                    "Сегодня ты боевая Базука!",
                    "Сегодня ты хитрая Базука!",
                    "Сегодня ты украинская Базука!",
                    "Сегодня ты изумленная Базука!",
                    "Сегодня ты грозная Базука!",
                    "Сегодня ты смеющаяся Базука!",
                    "Сегодня ты азартная Базука!",
                    "Сегодня ты деловая Базука!",
                    "Сегодня ты шокированная Базука!",
                    "Сегодня ты отчаянная Базука!",
                    "Сегодня ты ахуевшая Базука!",
                    "Сегодня ты задумчивая Базука!",
                    "Сегодня ты сексуальная Базука!",
                    "Сегодня ты флекс-Базука!",
                    "Сегодня ты пидор-Базука!",
                    "Сегодня ты украинская Базука!",
                    "Сегодня ты какающая Базука!",
                    "Сегодня ты довольная Базука!",
                    "Сегодня ты губастая Базука!",
                    "Сегодня ты ровная Базука!",
                    "Сегодня ты чемпионская Базука!",
                    "Сегодня ты сытая Базука!",
                    "Сегодня ты натужная Базука!",
                    "Сегодня ты огромная Базука!",
                    "Сегодня ты обычная Базука!"
                };
                    if (message != null && message.Text != null && message.Text.ToLower() == "базука кто я" && _isActive)
                    {
                        _isActive = true;
                        var fileUrl = $"pic//{randomizer}.jpg";
                        try
                        {
                            using (var stream = System.IO.File.Open(fileUrl, FileMode.Open))

                            {
                                await botClient.SendPhotoAsync(
                                    chatId: chatId,
                                    photo: stream,
                                    replyToMessageId: reply,
                                    caption: caption[randomizer - 1],
                                    cancellationToken: cancellationToken
                                    ); ;
                            }
                            return;
                        }
                        catch (Exception) { }
                    }
                }

                //if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
                //{
                //    var message = update.Message;
                //    if (message != null && message.Text != null && message.Text.Contains("базука") && ((message.Text.Contains("youtube") ^ message.Text.Contains("m.youtube.com/") ^ message.Text.Contains("youtu.be"))))
                //    {
                //        await botClient.SendTextMessageAsync(message.Chat, "АТАТАТАТАТАТАТАТАТА");
                //        return;
                //    }
                //}
                //if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
                //{
                //    var message = update.Message;
                //    if (message != null && message.Text != null && message.Text.Contains("базука") && ((message.Text.Contains("youtube") ^ message.Text.Contains("m.youtube.com/") ^ message.Text.Contains("youtu.be"))))
                //    {
                //        await botClient.SendTextMessageAsync(message.Chat, "АТАТАТАТАТАТАТАТАТА");
                //        return;
                //    }
                //}
                //if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
                //{
                //    var message = update.Message;
                //    if (message != null && message.Text != null && message.Text.Contains("базука") && ((message.Text.Contains("youtube") ^ message.Text.Contains("m.youtube.com/") ^ message.Text.Contains("youtu.be"))))
                //    {
                //        await botClient.SendTextMessageAsync(message.Chat, "АТАТАТАТАТАТАТАТАТА");
                //        return;
                //    }
                //}






                if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message && _isActive)
                {
                    var message = update.Message;
                    if (message != null && message.Text != null && message.Text.ToLower() == "базука завали ебало")
                    {
                        await botClient.SendTextMessageAsync(message.Chat, "Понял-понял, базару ноль! Аж в глазах потемнело...\n\nЧтобы включить меня, напиши 'Базука голос'");
                        _isActive = false;
                        return;
                    }
                }
                if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message && !_isActive)
                {
                    var message = update.Message;
                    if (message != null && message.Text != null && message.Text.ToLower() == "базука голос")
                    {
                        await botClient.SendTextMessageAsync(message.Chat, "АТАТАТА БЭБРА ВСТАЛА! \n\nЧтобы выключить меня, напиши 'Базука завали ебало'");
                        _isActive = true;
                        return;
                    }
                }
            }
            catch (Exception)
            {
            }
        }



        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );

            Console.ReadLine();
        }
    }
}