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
            Console.Write("Вы стоите перед торговцем кристаллами, заглядываете в свой кошелёк и видите там (введите количество золота): ");
            uint moneyPlayer = Convert.ToUInt32(Console.ReadLine());

            uint crystalTrader = 10;
            uint moneyCrystal = 10;
            uint moneyTrader = 0;
            
            Console.WriteLine($"Приветсвую путник, хотите купить кристаллы? У меня есть {crystalTrader}, по {moneyCrystal} за штуку.");
            Console.Write("Сколько вы хотите купить? ");
            uint crystalPlayer = Convert.ToUInt32(Console.ReadLine());

            moneyTrader = moneyCrystal * crystalPlayer;
            moneyPlayer = moneyPlayer - moneyCrystal * crystalPlayer;
            
            crystalTrader = crystalTrader - crystalPlayer;
            
            Console.WriteLine($"У торговца осталось {moneyTrader} золота и {crystalTrader} кристаллов");
            Console.WriteLine($"Теперь у вас {moneyPlayer} золота и {crystalPlayer} кристаллов");
        }
    }
}
