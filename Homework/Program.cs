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
            const int row = 3;
            const int picture = 52;
            
            int fullRow = picture / row;
            
            int restPictures = picture % row;

            Console.WriteLine($"Можно будет вывести {fullRow} полностью заполненных рядов.");
            Console.WriteLine($"Количество картинок сверх меры: {restPictures}.");
        }
    }
}
