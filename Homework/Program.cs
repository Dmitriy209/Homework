using System;

namespace UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ButtonExit = "exit";

            bool isRunnung = true;

            string hero = "    _\n" +
                "  0/u\n" +
                " <M\n" +
                "_/|";

            while (isRunnung)
            {
                Console.WriteLine($"Введите {ButtonExit}, чтобы выйти или что-нибудь, чтобы продолжить.");
                string userInput = Console.ReadLine();

                Console.Clear();

                switch (userInput)
                {
                    case ButtonExit:
                        isRunnung = false;
                        break;

                    default:
                        Console.WriteLine("Сколько процентов здоровья у вашего персонаж?");
                        int health = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Сколько максимум здоровья у вашего персонажа?");
                        int maxHealth = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Сколько процентов маны у вашего персонажа?");
                        int mana = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Сколько максимум маны у вашего персонажа?");
                        int maxMana = Convert.ToInt32(Console.ReadLine());

                        ConsoleColor healthBarColor = ConsoleColor.Green;
                        ConsoleColor manaBarColor = ConsoleColor.Blue;

                        int healthBarPositionX = 0;
                        int healthBarPositionY = 0;

                        int manaBarPositionX = 0;
                        int manaBarPositionY = 1;

                        Console.Clear();

                        DrawBar(health, maxHealth, healthBarColor, 0, 0);
                        DrawBar(mana, maxMana, manaBarColor, 0, 1);

                        Console.WriteLine("\n" + hero);
                        break;
                }
            }
        }

        static void DrawBar(int percentDraw, int lengthBar, ConsoleColor color = ConsoleColor.Green, int x = 0, int y = 0)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            int oneHundredPercent = 100;

            int valueBar = percentDraw * lengthBar / oneHundredPercent;
            int valueBarRemainder = percentDraw * lengthBar % oneHundredPercent;

            if (valueBar == 0 || valueBarRemainder > 0)
                valueBar = 1;

            for (int i = 0; i < valueBar; i++)
                bar += "#";

            Console.SetCursorPosition(x, y);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = valueBar; i < lengthBar; i++)
                bar += " ";

            Console.Write(bar + "]");
        }
    }
}
