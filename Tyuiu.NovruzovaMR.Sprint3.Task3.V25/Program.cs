using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NovruzovaMR.Sprint3.Task3.V25.Lib;

namespace Tyuiu.NovruzovaMR.Sprint3.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт №3 | Выполнил: Новрузова М.Р. | АСОиУБ-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Новрузова М.Р. | АСОиУБ-23-3                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв u,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке: kjhgfuu gujut dtuu           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "kjhgfuu gujut dtuu";
            char chr = 'u';
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + chr);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество символов = " + ds.GetMinCharCount(value, chr));
            Console.ReadKey();
        }
    }
}