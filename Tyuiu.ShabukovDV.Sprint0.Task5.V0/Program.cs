using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Подключение библеотеки
using Tyuiu.ShabukovDV.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ShabukovDV.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры
            Console.WriteLine("100 + 50 = " + DataService.Addition(100, 50));
            Console.WriteLine("15 - 5 = " + DataService.Subtraction(15, 5));
            Console.WriteLine("10 * 10 = " + DataService.Multiplication(10, 10));
            //Пример развлетвляющейся структуры находится в библеотеке классов в методе Division
            Console.WriteLine("9 / 3 = " + DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}
