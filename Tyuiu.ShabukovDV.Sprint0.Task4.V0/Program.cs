using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShabukovDV.Sprint0.Task4.V0.Lib;
namespace Tyuiu.ShabukovDV.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры программы
            //Вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(100, 50));
            //Вызов метода вычитания Subtraction
            Console.WriteLine(DataService.Subtraction(20, 2));
            //Вызов метода умножения Multiplication
            Console.WriteLine(DataService.Multiplication(15, 16));
            // Вызов метода деления Division
            Console.WriteLine(DataService.Division(50, 10));

            Console.ReadKey();
        }
    }
}
