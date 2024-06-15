using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество пациентов: ");
            uint linePeople = Convert.ToUInt32(Console.ReadLine());
            
            uint waitingOnePeople = 10;
            
            uint waitingLineHour = waitingOnePeople * linePeople / 60;
            uint waitingLineMinutes = waitingOnePeople * linePeople % 60;

            Console.WriteLine($"Вы должны отстоять в очереди {waitingLineHour} часа и {waitingLineMinutes} минут.");
        }
    }
}
