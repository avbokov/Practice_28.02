using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // тип массива [] имя массива;
            int[] arr = new int[5] { 1, 2 ,3, 4 ,5 };   // ссылка на массив
            int[] arr2; // создание массива
            int[] arr3 = new int[] { 1, 2, 3 }; // в фигурных скобках значения массива
            int[] arr4 = { 5, 6, 7, 8 };

            int[,] arr5 = new int[2, 3] { { 1, 2, 3 }, { 2, 3, 4, } };
            //  int[,,] arr6 = [2,2,3] { { { 1,2,3,}, { 4,5,6} }, { } };

            //  System.Array;   // все массивы наследуются от этого класса

            // Методы
            /*
            Array.GetLenght
            Array.GetLowerBound / Array.GetUpperBound 

            Array.CopyTo
            Array.Clone System.Object[] // для копирования лучше использовать этот метод
            Array.IndexOf / Array.LastIndexOf
            Array.Resize
            Array.Reverse
            Array.Sort

            Array.Sum
            Array.Anerage среднее арифметическое
            Array.Contains
            Array.Max
            Array.Min
            Array.Lenght
            Array.Rank
            */
            /*
            Array.Sort(arr);
            int[] myArr = new int[3];
            myArr.CopyTo(arr, 2);

            // зубчатый (ступенчатый) массив

            int[][] arr6 = new int[2][];
            arr6[0] = new int[5] { 1,2,3,4,5 };
            arr6[1] = new int[3] { 9,7,5};
            Console.WriteLine(arr6[0][3]);

            foreach(int i in arr)   // не позволяет изменять элементы массива, работает в режиме чтения
            {
                Console.Write(i);
            }
            */
            //string str = "Обычная строка";
            //string str2 = "строка";
            //string str3 = "Строка";
            //string[] strArr = { "ШАГ", "шагаем", "бежим", "ем" };

            //str.Lenght;
            //    str.Equals(str2);
            //String.Compare(str, str2);
            /*
            CopyTo
            Equals
            Compare
            CompareOrdinal
            CompareTo
            StarsWith / EndsWith

            IndexOf / LastIndexOf
            IndexOfAny / LastIndexOfAny
            SubString

            Concat
            ToLower / ToUpper
            Replace
            Contains
            Insert
            Remove
            PadLeft / PadRight
            Split
            Join
            Trim / TrimLeft / TrimRight

            */
            //Console.WriteLine(str + " Equals " + str2 + " : " + str.Equals(str2));
            //Console.WriteLine(str2 + " CompareTo " + str3 + " : " + str2.CompareTo(str3));

            /*string str1 = "Я ";
            string str2 = "учу ";
            string str3 = "С#";
            string str4 = str1+str2+str3;
            Console.WriteLine("{0} + {1} + {2} + {3}", str1, str2, str3, str4);
            str4 = str4.Replace("учу", "изучаю");
            Console.WriteLine(str4);

            str4 = str4.Insert(2, "упорно ").ToUpper();
            Console.WriteLine(str4);

            if (str4.Contains("упорно"))
                Console.WriteLine("Учу таки упорно:)");
            else
                Console.WriteLine("Учу как могу");

            str4 = str4.PadLeft(20, '*');
            str4 = str4.PadRight(30, '*');
            Console.WriteLine(str4);

            str4 = str4.TrimStart("*".ToCharArray());
            Console.WriteLine(str4);

            string[] strArr = str4.Split(" *".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in strArr)
                Console.WriteLine(str);

            str4 = str4.Remove(9);
            str4 += "учусь";
            Console.WriteLine(str4);
            */

            //  String.Format("text {index, size:spec}", str1);
            /* spec
            C / c
            D / d
            E / e
            F / f
            G / g
            N / n
            P / p   %
            X / x
            */
            /*
            double a = 99989.987;
            int b = 9999;

            Console.WriteLine(String.Format("C Format: {0,10:C}", a));
            Console.WriteLine(String.Format("D Format: {0:D9}", b));
            Console.WriteLine(String.Format("E Format: {0:E}", a));
            Console.WriteLine(String.Format("f Format: {0:F2}", a));
            Console.WriteLine(String.Format("G Format: {0:G}", a));
            Console.WriteLine(String.Format("N Format: {0,15:N}", b));                   
            Console.WriteLine(String.Format("P Format: {0:P}", a));                   
            Console.WriteLine(String.Format("X Format: {0:X}", b));

            int number = 145;
            string word = "qwert";
            double number2 = 23.02;
            Console.WriteLine($"{number:C}, {word}, {number2}");

            Console.WriteLine($"Число 1 {(a > b ? "больше" : "меньше")} числа 2");
            */

            // StringBuilder sb = new StringBuilder();
            /*  методы класса
            Append
            AppendFormat
            Insert
            Remove
            Replace
            CopyTo
            ToString
            Length
            Capacity
            Maxcapacity
            */
            /*
            //  sb = "hello";
            sb.Append("hello");
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("world");
            Console.WriteLine("Исходная строка");
            Console.WriteLine(sb);
            Console.WriteLine("Максимальное кол-во символов " + sb.Capacity);
            Console.WriteLine("Длина текущего объекта " + sb.Length);
            Console.WriteLine("Вставка строки");

            sb.Insert(7, "qwert");
            Console.WriteLine(sb);
            Console.WriteLine("Максимальное кол-во символов " + sb.Capacity);
            Console.WriteLine("Длина текущего объекта " + sb.Length);
            Console.WriteLine("Замена символов 'a' на 'z'");
            sb.Replace('o', 'z');
            Console.WriteLine(sb);

            Console.WriteLine("Удаление 10 символов, начаиная с 3");
            sb.Remove(3, 10);
            Console.WriteLine(sb);
            Console.WriteLine("Максимальное кол-во символов " + sb.Capacity);
            Console.WriteLine("Длина текущего объекта " + sb.Length);
            */

            int[] arr = { 48, 23, 16, 25, 23, 15, 15 };

            /*int edd=0, even=0, uniq=0;

            foreach (int i in arr)
            {
                if (i % 2 == 0)
                    even++;
                else
                    edd++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(arr, arr[i]) == Array.LastIndexOf(arr, arr[i]))
                    uniq++;
            }
            */

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            uniq++;
            //    }
            //}

            //Console.WriteLine(even);
            //Console.WriteLine(edd);
            //Console.WriteLine(uniq);
            //Console.WriteLine(arr.Length - (uniq * 2));

            int num = Int32.Parse(Console.ReadLine());
            int counter = 0;
           
            foreach (int i in arr)
            {
                if (i < num)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

            Console.ReadLine();
        }
    }
}
