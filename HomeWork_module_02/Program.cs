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
                //if (i % 2 == 0) sum_chet += arr1[i];      // сумма по чётным индексам (я так понял задание).
                if (arr1[i] % 2 == 0) sum_chet += arr1[i];  // Если нужно суммировать чётные значения, тут легко переделать.
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
            if (max1 == max2) Console.WriteLine($"Общий максимальный элемент: {max1}");
            else Console.WriteLine($"Общего максимального элемента нет");
            if (min1 == min2) Console.WriteLine($"Общий максимальный элемент: {min1}");
            else Console.WriteLine($"Общего минимального элемента нет");
            //Console.WriteLine($"Общий максимальный элемент: {(max1 > max2 ? max1 : max2)}");
            //Console.WriteLine($"Общий минимальный элемент: {(min1 < min2 ? min1 : min2)}"); 
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
            // В ссылке шифр Цезаря на инглише, буду реализовывать для латинницы. Для кириллицы принцип тот же самый.
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

#if false
            const int ROWS1 = 3;
            const int COLS1 = 3;

            int[,] arr1 = new int[ROWS1, COLS1];
            int[,] arr2 = new int[ROWS1, COLS1];
            int[,] arr_composition = new int[ROWS1, COLS1];

            Random rnd = new Random();

            for (int i = 0; i < ROWS1; i++)
            {
                for (int j = 0; j < COLS1; j++)
                {
                    arr1[i,j] = rnd.Next(10);
                    arr2[i,j] = rnd.Next(10);                   
                }
            }

            Console.WriteLine("Матрица 1:");

            for (int i = 0; i < ROWS1; i++)
            {
                for (int j = 0; j < COLS1; j++)
                {
                    Console.Write($"{arr1[i,j]} ");                  
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Матрица 2:");

            for (int i = 0; i < ROWS1; i++)
            {
                for (int j = 0; j < COLS1; j++)
                {
                    Console.Write($"{arr2[i,j]} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Сумма матрицы 1 и матрицы 2:");

            for (int i = 0; i < ROWS1; i++)
            {
                for (int j = 0; j < COLS1; j++)
                {
                    Console.Write($"{arr1[i,j] + arr2[i,j]} ");
                }
                Console.WriteLine("");
            }

            int result_composition = 0;

            for (int k = 0; k < ROWS1; k++)
            {
                for (int l = 0; l < COLS1; l++)
                {
                    for (int j = 0; j < COLS1; j++)
                    {
                        result_composition = result_composition + arr1[k,j] * arr2[j,l];
                    }
                    arr_composition[k,l] = result_composition;
                    result_composition = 0;
                }
            }
            
            Console.WriteLine("Перемножение матрицы 1 и матрицы 2:");

            for (int i = 0; i < ROWS1; i++)
            {
                for (int j = 0; j < COLS1; j++)
                {
                    Console.Write($"{arr_composition[i,j]} ");
                }
                Console.WriteLine("");
            }

            Console.Write("Введите число: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Перемножение матрицы 1 и числа:");

            for (int i = 0; i < ROWS1; i++)
            {
                for (int j = 0; j < COLS1; j++)
                {
                    Console.Write($"{arr1[i, j]*a} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Перемножение матрицы 2 и числа:");

            for (int i = 0; i < ROWS1; i++)
            {
                for (int j = 0; j < COLS1; j++)
                {
                    Console.Write($"{arr2[i, j] * a} ");
                }
                Console.WriteLine("");
            }

#endif
            // Задание 5

#if false
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            string str1, str2;

            if (str.IndexOf("+") > 0)
            {
                str1 = str.Substring(0, str.Length - (str.IndexOf("+") + 1));
                str2 = str.Substring(str.IndexOf("+") + 1);
                Console.WriteLine($"Сумма {Convert.ToInt32(str1)} и {Convert.ToInt32(str2)} равна: {Convert.ToInt32(str1) + Convert.ToInt32(str2)}");
            }
            else if (str.IndexOf("-") > 0)
            {
                str1 = str.Substring(0, str.Length - (str.IndexOf("-") + 1));
                str2 = str.Substring(str.IndexOf("-") + 1);
                Console.WriteLine($"Разность {Convert.ToInt32(str1)} и {Convert.ToInt32(str2)} равна: {Convert.ToInt32(str1) - Convert.ToInt32(str2)}");
            }
            else Console.WriteLine("Введено НЕ арифметическое выражение");    
#endif
            // Задание 6

#if false
            //  today is a good day for walking. i will try to walk near the sea.
            //  today is a good day for walking.i will try to walk near the sea.
            //  today is a good day for walking! i will try to walk near the sea.
            //  today is a good day for walking!i will try to walk near the sea.
            //  today is a good day for walking? i will try to walk near the sea.
            //  today is a good day for walking?i will try to walk near the sea.

            Console.WriteLine("Введите текст:");
            string str = Console.ReadLine().ToLower();
            char[] str1 = new char[str.Length];

            str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 && str[i] != ' ') str1[i] = char.ToUpper(str[i]);
                else if (i == 0 && str[i + 1] != ' ')
                {
                    str1[i + 1] = char.ToUpper(str[i + 1]);
                    str1[i] = ' ';
                    i++;
                }
                else if ((str[i] == '.' || str[i] == '!' || str[i] == '?') && i + 1 < str.Length && str[i + 1] == ' ' && i + 2 < str.Length)
                {
                    str1[i] = str[i];
                    str1[i + 1] = str[i + 1];
                    str1[i + 2] = char.ToUpper(str[i + 2]);
                    i += 2;
                }
                else if ((str[i] == '.' || str[i] == '!' || str[i] == '?') && i + 1 < str.Length && str[i + 1] != ' ')
                {
                    str1[i] = str[i];
                    str1[i + 1] = char.ToUpper(str[i + 1]);
                    i++;
                }
                else str1[i] = str[i];
            }

            foreach (char i in str1)
                Console.Write($"{i}"); 
#endif
            // Задание 7

#if false
            // To be, or not to be, that is the question, Whether 'tis nobler in the mind to suffer. The slings and arrows of outrageous fortune, Or to take arms against a sea of troubles,

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите плохое слово:");
            string badWord = Console.ReadLine();
            string correctText = text.Replace(badWord, "***");  // проверка как есть, например, если введено слово в верхнем регистре
            badWord = badWord.ToLower();
            correctText = correctText.Replace(badWord, "***");  // проверка на слово в нижнем регистре
            badWord = badWord.Substring(0, 1).ToUpper() + (badWord.Length > 1 ? badWord.Substring(1, badWord.Length - 1) : "");
            correctText = correctText.Replace(badWord, "***");  // проверка, если первая буква заглавная

            Console.Write(correctText); 
#endif

            Console.ReadLine();
        }

    }
}
