using System;

namespace Readlnt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber = GetUserNumber();

            Console.WriteLine($"Вы ввели {userNumber}.");
        }

        private static int GetUserNumber()
        {
            int userNumber = 0;

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Введите целочисленное число:");
                string inputLine = Console.ReadLine();

                bool isUserNumber = int.TryParse(inputLine, out userNumber);

                if (isUserNumber)
                    isRunning = false;
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{inputLine} - не целочисленное число.");
                }
            }

            return userNumber;
        }
    }
}
