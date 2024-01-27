using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NovruzovaMR.Sprint3.Task0.V22.Lib;

namespace Tyuiu.NovruzovaMR.Sprint3.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double a; int start; int stop;

            Console.Title = "Спринт #2 | Выполнила: Новрузова М. Р. | АСОиУБ-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Новрузова М. Р. | АСОиУБ-23-3                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
            Console.WriteLine("* ряда по формуле, при a=0,25                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стартовое значение: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите предел произведения ряда: ");
            stop = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine($"Произведение Ряда равно:\n{ds.GetMultiplySeries(a, start, stop)}");
            Console.ReadKey();
        }
    }
}