using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram_Bot
{
    class Program
    {
        private static string token { get; set; } = "1821248150:AAGKGIu5FmiadCQ5OVJDBz2YD7En2VvWTFA";
        private static TelegramBotClient Client;
        public static int f = 0;
        public static string[] Checkmas = new string[7] { "[X]", "[X]", "[X]", "[X]", "[X]", "[X]", "[X]" };
        static void Main(string[] args)
        {
            Client = new TelegramBotClient(token);
            Client.StartReceiving();
            Client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            Client.StopReceiving();

        }
        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text != null)
            {
                Console.WriteLine($"Usop: {msg.Text}");
                if (msg.Text == "Первый рабочий день старуй!" && f == 0)
                {
                    f = 1;
                    await Client.SendTextMessageAsync(msg.Chat.Id, "1-ый день важный .... Чек-лист поможет узреть и сделать всё необходимое в первый день....", replyMarkup: GetButtons2());
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Чек-лист:\n\n" + Checkmas[0] + " Зайди в бухгалтерию, подписать документы на трудоустройство и познакомиться с нашим очаровательным бухгалтером Еленой\n\n" + Checkmas[1] + " Получить у Елены ключ от комнаты, пароль от входной двери и пропуск в здание\n\n" + Checkmas[2] + " Попроси Людмилу провести экскурсию по офису\n\n" + Checkmas[3] + " Познакомься с ГСА и получи welcome back, вдеть у системного администратора Лёши или Саши пароль к учётной записи, к почте\n\n" + Checkmas[4] + " Освоиться на рабочем месте, покачаться в удобном кресле, включить комп\n\n" + Checkmas[5] + " Установить телегу и продолжить общение со мной с компа\n\n" + Checkmas[6] + " Зайди на рабочую почту открой письмо от Redmine. Там твоя первая задача -> заполни необходимую информацию", replyMarkup: GetButtons2());
                }
                else if (msg.Text == "Зайди в бухгалтерию, подписать документы на трудоустройство и познакомиться с нашим очаровательным бухгалтером Еленой" && f == 1)
                {
                    Checkmas[0] = "[V]";
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Чек-лист:\n\n" + Checkmas[0] + " Зайди в бухгалтерию, подписать документы на трудоустройство и познакомиться с нашим очаровательным бухгалтером Еленой\n\n" + Checkmas[1] + " Получить у Елены ключ от комнаты, пароль от входной двери и пропуск в здание\n\n" + Checkmas[2] + " Попроси Людмилу провести экскурсию по офису\n\n" + Checkmas[3] + " Познакомься с ГСА и получи welcome back, вдеть у системного администратора Лёши или Саши пароль к учётной записи, к почте\n\n" + Checkmas[4] + " Освоиться на рабочем месте, покачаться в удобном кресле, включить комп\n\n" + Checkmas[5] + " Установить телегу и продолжить общение со мной с компа\n\n" + Checkmas[6] + " Зайди на рабочую почту открой письмо от Redmine. Там твоя первая задача -> заполни необходимую информацию", replyMarkup: GetButtons2());
                }
                else if (msg.Text == "Получить у Елены ключ от комнаты, пароль от входной двери и пропуск в здание" && f == 1)
                {
                    Checkmas[1] = "[V]";
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Чек-лист:\n\n" + Checkmas[0] + " Зайди в бухгалтерию, подписать документы на трудоустройство и познакомиться с нашим очаровательным бухгалтером Еленой\n\n" + Checkmas[1] + " Получить у Елены ключ от комнаты, пароль от входной двери и пропуск в здание\n\n" + Checkmas[2] + " Попроси Людмилу провести экскурсию по офису\n\n" + Checkmas[3] + " Познакомься с ГСА и получи welcome back, вдеть у системного администратора Лёши или Саши пароль к учётной записи, к почте\n\n" + Checkmas[4] + " Освоиться на рабочем месте, покачаться в удобном кресле, включить комп\n\n" + Checkmas[5] + " Установить телегу и продолжить общение со мной с компа\n\n" + Checkmas[6] + " Зайди на рабочую почту открой письмо от Redmine. Там твоя первая задача -> заполни необходимую информацию", replyMarkup: GetButtons2());
                }
                else if (msg.Text == "Попроси Людмилу провести экскурсию по офису" && f == 1)
                {
                    Checkmas[2] = "[V]";
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Чек-лист:\n\n" + Checkmas[0] + " Зайди в бухгалтерию, подписать документы на трудоустройство и познакомиться с нашим очаровательным бухгалтером Еленой\n\n" + Checkmas[1] + " Получить у Елены ключ от комнаты, пароль от входной двери и пропуск в здание\n\n" + Checkmas[2] + " Попроси Людмилу провести экскурсию по офису\n\n" + Checkmas[3] + " Познакомься с ГСА и получи welcome back, вдеть у системного администратора Лёши или Саши пароль к учётной записи, к почте\n\n" + Checkmas[4] + " Освоиться на рабочем месте, покачаться в удобном кресле, включить комп\n\n" + Checkmas[5] + " Установить телегу и продолжить общение со мной с компа\n\n" + Checkmas[6] + " Зайди на рабочую почту открой письмо от Redmine. Там твоя первая задача -> заполни необходимую информацию", replyMarkup: GetButtons2());
                }
                else if (msg.Text == "Познакомься с ГСА и получи welcome back, вдеть у системного администратора Лёши или Саши пароль к учётной записи, к почте" && f == 1)
                {
                    Checkmas[3] = "[V]";
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Чек-лист:\n\n" + Checkmas[0] + " Зайди в бухгалтерию, подписать документы на трудоустройство и познакомиться с нашим очаровательным бухгалтером Еленой\n\n" + Checkmas[1] + " Получить у Елены ключ от комнаты, пароль от входной двери и пропуск в здание\n\n" + Checkmas[2] + " Попроси Людмилу провести экскурсию по офису\n\n" + Checkmas[3] + " Познакомься с ГСА и получи welcome back, вдеть у системного администратора Лёши или Саши пароль к учётной записи, к почте\n\n" + Checkmas[4] + " Освоиться на рабочем месте, покачаться в удобном кресле, включить комп\n\n" + Checkmas[5] + " Установить телегу и продолжить общение со мной с компа\n\n" + Checkmas[6] + " Зайди на рабочую почту открой письмо от Redmine. Там твоя первая задача -> заполни необходимую информацию", replyMarkup: GetButtons2());
                }
                else if (msg.Text == "Освоиться на рабочем месте, покачаться в удобном кресле, включить комп" && f == 1)
                {
                    Checkmas[4] = "[V]";
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Чек-лист:\n\n" + Checkmas[0] + " Зайди в бухгалтерию, подписать документы на трудоустройство и познакомиться с нашим очаровательным бухгалтером Еленой\n\n" + Checkmas[1] + " Получить у Елены ключ от комнаты, пароль от входной двери и пропуск в здание\n\n" + Checkmas[2] + " Попроси Людмилу провести экскурсию по офису\n\n" + Checkmas[3] + " Познакомься с ГСА и получи welcome back, вдеть у системного администратора Лёши или Саши пароль к учётной записи, к почте\n\n" + Checkmas[4] + " Освоиться на рабочем месте, покачаться в удобном кресле, включить комп\n\n" + Checkmas[5] + " Установить телегу и продолжить общение со мной с компа\n\n" + Checkmas[6] + " Зайди на рабочую почту открой письмо от Redmine. Там твоя первая задача -> заполни необходимую информацию", replyMarkup: GetButtons2());
                }
                else if (msg.Text == "Установить телегу и продолжить общение со мной с компа" && f == 1)
                {
                    Checkmas[5] = "[V]";
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Чек-лист:\n\n" + Checkmas[0] + " Зайди в бухгалтерию, подписать документы на трудоустройство и познакомиться с нашим очаровательным бухгалтером Еленой\n\n" + Checkmas[1] + " Получить у Елены ключ от комнаты, пароль от входной двери и пропуск в здание\n\n" + Checkmas[2] + " Попроси Людмилу провести экскурсию по офису\n\n" + Checkmas[3] + " Познакомься с ГСА и получи welcome back, вдеть у системного администратора Лёши или Саши пароль к учётной записи, к почте\n\n" + Checkmas[4] + " Освоиться на рабочем месте, покачаться в удобном кресле, включить комп\n\n" + Checkmas[5] + " Установить телегу и продолжить общение со мной с компа\n\n" + Checkmas[6] + " Зайди на рабочую почту открой письмо от Redmine. Там твоя первая задача -> заполни необходимую информацию", replyMarkup: GetButtons2());
                }
                else if (msg.Text == "Зайди на рабочую почту открой письмо от Redmine. Там твоя первая задача -> заполни необходимую информацию" && f == 1)
                {
                    Checkmas[6] = "[V]";
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Чек-лист:\n\n" + Checkmas[0] + " Зайди в бухгалтерию, подписать документы на трудоустройство и познакомиться с нашим очаровательным бухгалтером Еленой\n\n" + Checkmas[1] + " Получить у Елены ключ от комнаты, пароль от входной двери и пропуск в здание\n\n" + Checkmas[2] + " Попроси Людмилу провести экскурсию по офису\n\n" + Checkmas[3] + " Познакомься с ГСА и получи welcome back, вдеть у системного администратора Лёши или Саши пароль к учётной записи, к почте\n\n" + Checkmas[4] + " Освоиться на рабочем месте, покачаться в удобном кресле, включить комп\n\n" + Checkmas[5] + " Установить телегу и продолжить общение со мной с компа\n\n" + Checkmas[6] + " Зайди на рабочую почту открой письмо от Redmine. Там твоя первая задача -> заполни необходимую информацию", replyMarkup: GetButtons2());
                }
                else if (msg.Text == "Назад" && f == 1)
                {
                    f = 0;
                    await Client.SendTextMessageAsync(msg.Chat.Id, "ок :c", replyMarkup: GetButtons1());
                }
                else if (msg.Text == "История Инреко ЛАН" && f == 0)
                {
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Что-то, что нужно вывести после нажатия на 2 кнопку", replyMarkup: GetButtons1());
                }
                else if (msg.Text == "Инреко ЛАН сегодня" && f == 0)
                {
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Что-то, что нужно вывести после нажатия на 3 кнопку", replyMarkup: GetButtons1());
                }
                else if (msg.Text == "Наши достижения" && f == 0)
                {
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Что-то, что нужно вывести после нажатия на 4 кнопку", replyMarkup: GetButtons1());
                }
                else if (msg.Text == "Общество, жизнь и традиции" && f == 0)
                {
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Что-то, что нужно вывести после нажатия на 5 кнопку", replyMarkup: GetButtons1());
                }
                else if (msg.Text == "Внутренние коммуникации и информационные ресурсы" && f == 0)
                {
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Что-то, что нужно вывести после нажатия на 6 кнопку", replyMarkup: GetButtons1());
                }
                else if (msg.Text == "СУРВ" && f == 0)
                {
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Что-то, что нужно вывести после нажатия на 7 кнопку", replyMarkup: GetButtons1());
                }
                else if (msg.Text == "Отпуск" && f == 0)
                {
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Что-то, что нужно вывести после нажатия на 8 кнопку", replyMarkup: GetButtons1());
                }
                else if (msg.Text == "Здоровье" && f == 0)
                {
                    await Client.SendTextMessageAsync(msg.Chat.Id, "Что-то, что нужно вывести после нажатия на 9 кнопку", replyMarkup: GetButtons1());
                }
                else await Client.SendTextMessageAsync(msg.Chat.Id, "Выберите кнопочку :3", replyMarkup: GetButtons1());
            }
        }

        private static IReplyMarkup GetButtons1()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{new KeyboardButton {  Text = "Первый рабочий день старуй!"}, new KeyboardButton { Text = "История Инреко ЛАН" } , new KeyboardButton { Text = "Инреко ЛАН сегодня" } },
                    new List<KeyboardButton>{new KeyboardButton {  Text = "Наши достижения"}, new KeyboardButton { Text = "Общество, жизнь и традиции" } , new KeyboardButton { Text = "Внутренние коммуникации и информационные ресурсы" } },
                    new List<KeyboardButton>{new KeyboardButton {  Text = "СУРВ"}, new KeyboardButton { Text = "Отпуск" } , new KeyboardButton { Text = "Здоровье" } },
                }
            };
        }
        private static IReplyMarkup GetButtons2()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{new KeyboardButton {  Text = "Зайди в бухгалтерию, подписать документы на трудоустройство и познакомиться с нашим очаровательным бухгалтером Еленой"}, new KeyboardButton { Text = "Получить у Елены ключ от комнаты, пароль от входной двери и пропуск в здание" } },
                    new List<KeyboardButton>{new KeyboardButton {  Text = "Попроси Людмилу провести экскурсию по офису" }, new KeyboardButton { Text = "Познакомься с ГСА и получи welcome back, вдеть у системного администратора Лёши или Саши пароль к учётной записи, к почте" } },
                    new List<KeyboardButton>{new KeyboardButton {  Text = "Освоиться на рабочем месте, покачаться в удобном кресле, включить комп" }, new KeyboardButton { Text = "Установить телегу и продолжить общение со мной с компа" } },
                    new List<KeyboardButton>{new KeyboardButton {  Text = "Зайди на рабочую почту открой письмо от Redmine. Там твоя первая задача -> заполни необходимую информацию"} },
                    new List<KeyboardButton>{new KeyboardButton {  Text = "Назад"} },
                }
            };
        }
    } // 
}