using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_modul_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
#if false
            int[] arr1 = new int[5];
            int rows = 3, cols = 4;
            double[,] arr2 = new double[rows, cols]; // 3 строки, 4 столбца
            int max1 = 0, min1 = 0, sum1 = 0, sum_chet = 0;
            long mult1 = 1;
            double max2 = 0, min2 = 0, sum2 = 0, mult2 = 1, sum_nech_cols = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                arr1[i] = Int32.Parse(Console.ReadLine());
                if (i == 0) { min1 = max1 = arr1[i]; }
                sum1 += arr1[i];
                if (i % 2 == 0) sum_chet += arr1[i];    // сумма по чётным индексам (я так понял задание). Если нужно суммировать чётные значения, тут легко переделать.
                if (arr1[i] < min1) min1 = arr1[i];
                if (arr1[i] > max1) max1 = arr1[i];
                mult1 *= arr1[i];
            }

            Console.Write("Одномерный массив: ");
            foreach (int i in arr1)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("");

            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr2[i, j] = rnd.NextDouble() * 100;
                    Console.Write($"{arr2[i, j]} ");
                    if (i == 0 && j == 0) { min2 = max2 = arr2[i, j]; }
                    sum2 += arr2[i, j];
                    if (j % 2 == 1) sum_nech_cols += arr2[i, j];
                    if (arr2[i, j] < min2) min2 = arr2[i, j];
                    if (arr2[i, j] > max2) max2 = arr2[i, j];
                    mult2 *= arr2[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма чётных элементов массива А: {sum_chet}");
            Console.WriteLine($"Сумма элементов в нечётных столбцах массива В: {sum_nech_cols}");
            Console.WriteLine($"Общая сумма элементов массивов: {sum1 + sum2}");
            Console.WriteLine($"Общее произведение элементов массивов: {mult1 * mult2}");
            Console.WriteLine($"Общий максимальный элемент: {(max1 > max2 ? max1 : max2)}");
            Console.WriteLine($"Общий минимальный элемент: {(min1 < min2 ? min1 : min2)}"); 
#endif

            // Задание 2
#if false


            int rows = 5, cols = 5;
            int[,] arr2 = new int[rows, cols];
            int max2 = 0, min2 = 0, sum2 = 0;
            int i_min = 0, i_max = 0, j_min = 0, j_max = 0;
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr2[i, j] = rnd.Next(-100,100);
                    Console.Write($"{arr2[i, j]} ");
                    if (i == 0 && j == 0) { min2 = max2 = arr2[i, j]; }
                    if (arr2[i, j] < min2)
                    {
                        min2 = arr2[i, j];
                        i_min = i;
                        j_min = j;
                    }
                    if (arr2[i, j] > max2)
                    {
                        max2 = arr2[i, j];
                        i_max = i;
                        j_max = j;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Минимальный элемент: {min2}");
            Console.WriteLine($"Максимальный элемент: {max2}");
            Console.WriteLine($"Координаты минимального элемента: {i_min}, {j_min}");
            Console.WriteLine($"Координаты максимального элемента: {i_max}, {j_max}");

            if (i_min != i_max)
            {
                for (int i = (i_min < i_max ? i_min : i_max); i <= (i_min < i_max ? i_max : i_min); i++)
                {
                    if ((i_min < i_max && i != i_max) || (i_min > i_max && i != i_min))
                    {
                        for (int j = (i_min < i_max ? j_min : j_max); j < cols; j++)
                        {
                            sum2 += arr2[i, j];
                        }
                    }
                    else if (i != i_min && i != i_max)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            sum2 += arr2[i, j];
                        }
                    }
                    else if ((i_min < i_max && i == i_max) || (i_min > i_max && i == i_min))
                    {
                        for (int j = 0; j <= (i_min < i_max ? j_max : j_min); j++)
                        {
                            sum2 += arr2[i, j];
                        }
                    }
                }
            }
            else
            {
                for (int i = i_min; i <= i_min; i++)
                {
                    for (int j = (j_min < j_max ? j_min : j_max); j <= (j_min < j_max ? j_max : j_min); j++)
                    {
                        sum2 += arr2[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма элементов между максимальным и минимальным элементами: {sum2 - min2 - max2}"); 
#endif

            // Задание 3

#if false
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine().ToLower();

            int[] asci = new int[128];

            Console.WriteLine("\nДля шифрования строки шифром Цезаря, нажмите 1\nДля расшифровки, нажмите 2");
            int choice = Int32.Parse(Console.ReadLine());

            if (choice == 1)    //  Шифруем
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if ((int)str[i] > 99 && (int)str[i] < 123)
                    {
                        asci[i] = (int)str[i] - 3;
                    }
                    else if ((int)str[i] > 96 && (int)str[i] < 100)
                    {
                        asci[i] = (int)str[i] + 23;
                    }
                    else if ((int)str[i] == 32) asci[i] = 32;
                }
            }

            if (choice == 2)    //  Дешифруем
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if ((int)str[i] > 96 && (int)str[i] < 120)
                    {
                        asci[i] = (int)str[i] + 3;
                    }
                    else if ((int)str[i] > 119 && (int)str[i] < 123)
                    {
                        asci[i] = (int)str[i] - 23;
                    }
                    else if ((int)str[i] == 32) asci[i] = 32;
                }
            }

            foreach (char i in asci)
                Console.Write(i); 
#endif
            // Задание 4

            Console.ReadLine();
        }

    }
}
