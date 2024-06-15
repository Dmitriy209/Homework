using System;


namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество пациентов: ");
            uint linePeople = Convert.ToUInt32(Console.ReadLine());
            
            uint waitingOnePeople = 10;
            uint minutesInHour = 60;

            uint waitingTime = waitingOnePeople * linePeople;
            
            uint waitingLineHour = waitingTime / minutesInHour;
            uint waitingLineMinutes = waitingTime % minutesInHour;

            Console.WriteLine($"Вы должны отстоять в очереди {waitingLineHour} часа и {waitingLineMinutes} минут.");
        }
    }
}
