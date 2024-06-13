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
            int rows = 3;
            int picture = 52;
            
            int fullRow = picture / rows;
            
            int restPictures = picture % rows;

            Console.WriteLine($"Можно будет вывести {fullRow} полностью заполненных рядов.");
            Console.WriteLine($"Количество картинок сверх меры: {restPictures}.");
        }
    }
}
