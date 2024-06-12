using System;
using System.Collections.Generic;
using System.Linq;
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
            string name, SignOfTheZodiac, workName;
            int age;
            Console.WriteLine("Как вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой ваш знак зодиака?");
            SignOfTheZodiac = Console.ReadLine();
            Console.WriteLine("Где вы работаете? (пример: в офисе, на заводе)");
            workName = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}, вам {age}, вы {SignOfTheZodiac} и работаете {workName}");
        }
    }
}
