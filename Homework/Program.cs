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
            string vodkaGlass = "пиво";
            string bearGlass = "водка";

            Console.WriteLine($"Вы заглядваете в рюмку и видете, что там {vodkaGlass}.\n" +
                $"Вы заглядываете в пивной бокал и видите, что там {bearGlass}.\n" +
                "Официант замечает это и ловким движением руки переливает напитки в нужные ёмкости.");

            string magicMixer = vodkaGlass; 

            vodkaGlass = bearGlass;
            bearGlass = magicMixer;

            Console.WriteLine($"Теперь вы видите, что в рюмке {vodkaGlass}, а в пивном бокале {bearGlass}");
        }
    }
}
