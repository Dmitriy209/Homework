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
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            
            Console.WriteLine("Сколько вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Какой ваш знак зодиака?");
            string zodiacSign = Console.ReadLine();

            Console.WriteLine("Где вы работаете? (пример: в офисе, на заводе)");
            string workName = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age}, вы {zodiacSign} и работаете {workName}");
        }
    }
}
