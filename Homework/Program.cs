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
            uint playerMoney = Convert.ToUInt32(Console.ReadLine());

            uint crystalTrader = 10;
            uint crystalPrice = 10;
            uint traderMoney = 0;
            
            Console.WriteLine($"Приветсвую путник, хотите купить кристаллы? У меня есть {crystalTrader}, по {crystalPrice} за штуку.");
            Console.Write("Сколько вы хотите купить? ");
            uint playerCrystal = Convert.ToUInt32(Console.ReadLine());

            traderMoney = crystalPrice * playerCrystal;
            playerMoney = playerMoney - crystalPrice * playerCrystal;
            
            crystalTrader -= playerCrystal;
            
            Console.WriteLine($"У торговца осталось {traderMoney} золота и {crystalTrader} кристаллов");
            Console.WriteLine($"Теперь у вас {playerMoney} золота и {playerCrystal} кристаллов");
        }
    }
}
