using System;


namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение:");
            string message = Console.ReadLine();

            Console.WriteLine("Введите количество повторений сообщения:");
            int amountMessage = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amountMessage; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
