using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint4.V9.Reviev.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.V9.Reviev
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "864299753";

            DataService ds = new DataService();
            Console.Title = "Спринт 4. Выполнил: Иванчиков Дмитрий Александрович | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Итоговое задание по спринту                                       *");
            Console.WriteLine("* Задание #Reviev                                                         *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Иванчиков Д.А. | ПКТб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("Дана строка из одноразрядных цифр 864299753.                              *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и подсчитайте                          *");
            Console.WriteLine("* количество четных чисел.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\n Массив : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine("Количество четных элементов = " + res);
            Console.ReadKey();
        }
    }
}
