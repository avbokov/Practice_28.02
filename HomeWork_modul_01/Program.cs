using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeWork_modul_01
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задание 1
            //Console.Write("Введите число от 1 до 100: \n");
            //int a = Int32.Parse(Console.ReadLine());
            //if (a < 1 || a > 100)
            //{
            //    Console.WriteLine("Error!");
            //    return;
            //}
            //if (a % 3 == 0 && a % 5 == 0) Console.WriteLine("Fizz Buzz");
            //else if (a % 3 == 0) Console.WriteLine("Fizz");
            //else if (a % 5 == 0) Console.WriteLine("Buzz");
            //else Console.WriteLine(a);

            // Задание 2
            //Console.Write("Введите число: ");
            //int a = Int32.Parse(Console.ReadLine());
            //Console.Write("Введите процент: ");
            //int b = Int32.Parse(Console.ReadLine());
            //Console.Write($"{b} % от числа {a} равно {((double)a / 100) * b}");

            // Задание 3
            //Console.Write("Введите первое число: ");
            //int a = Int32.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //int b = Int32.Parse(Console.ReadLine());
            //Console.Write("Введите третье число: ");
            //int c = Int32.Parse(Console.ReadLine());
            //Console.Write("Введите четвёртое число: ");
            //int d = Int32.Parse(Console.ReadLine());
            //Console.Write($"Получилось: {a*1000+b*100+c*10+d}");

            // Задание 4
            //Console.Write("Введите шестизначное число: ");
            //int number = Int32.Parse(Console.ReadLine());
            //if (number < 1e05 || number >= 1e06) Console.Write("Введено не шестизначное число. Ошибка.");
            //else
            //{
            //    Console.WriteLine($"Введите номера разрядов цифр для обмена: ");
            //    int first = Int32.Parse(Console.ReadLine()) - 1;    // -1 чтобы работать дальше с индексами
            //    int second = Int32.Parse(Console.ReadLine()) - 1;

            //    string c = Convert.ToString(number);

            //    for (int i = 0; i < c.Length; i++)    // я понимаю, что строка на самом деле не изменилась, но она вывелась в консоль визуально так, как мне надо
            //    {
            //        if (i == first)
            //        {
            //            Console.Write(c[second]);
            //        }
            //        else if (i == second)
            //        {
            //            Console.Write(c[first]);
            //        }
            //        else Console.Write(c[i]);
            //    }
            //}

            // Задание 5

#if false
            bool visokos = false;
            bool step = false;
            int year = 0, month = 0, day = 0;
            while (!step)
            {
                Console.Write("Введите год (1584-2022): ");
                year = Int32.Parse(Console.ReadLine());
                if (year < 1584 || year > 2022)
                {
                    Console.WriteLine("Введите корректные данные!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    if (year % 4 == 0 && year % 100 != 0)
                    {
                        Console.WriteLine("Выбран високосный год!");
                        visokos = true;
                    }
                    else if (year % 400 == 0)
                    {
                        Console.WriteLine("Выбран високосный год!");
                        visokos = true;
                    }
                    step = true;
                }
            }
            step = false;

            while (!step)
            {
                Console.Write("Введите месяц (1-12): ");
                month = Int32.Parse(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Введите корректные данные!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    step = true;
                }
            }
            step = false;

            while (!step)
            {
                if (month == 2 && visokos == true) Console.WriteLine("В этом месяце 29 дней");
                else if (month == 2 && visokos == false) Console.WriteLine("В этом месяце 28 дней");
                else if (month == 4 || month == 6 || month == 9 || month == 11) Console.WriteLine("В этом месяце 30 дней");
                else Console.WriteLine("В этом месяце 31 день");
                Console.Write("Введите число (1-31): ");
                day = Int32.Parse(Console.ReadLine());
                if (day < 1 || day > 31)
                {
                    Console.WriteLine("Введите корректные данные!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else if (month == 2 && visokos == true && day > 29)
                {
                    Console.WriteLine("Введите корректные данные!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else if (month == 2 && visokos == false && day > 28)
                {
                    Console.WriteLine("Введите корректные данные!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
                {
                    Console.WriteLine("Введите корректные данные!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else step = true;
            }

            if (month < 10 && day < 10) Console.Write($"Введена дата: 0{day}.0{month}.{year}");
            else if (day < 10) Console.Write($"Введена дата: 0{day}.{month}.{year}");
            else if (month < 10) Console.Write($"Введена дата: {day}.0{month}.{year}");
            else Console.WriteLine($"Введена дата: {day}.{month}.{year}");

            Console.WriteLine();
            int index_year = year - (14 - month) / 12;
            int index_month = month + 12 * ((14 - month) / 12) - 2;
            int day_of_week = (7000 + (day + index_year + (index_year / 4) - (index_year / 100) + (index_year / 400) + ((31 * index_month) / 12))) % 7;

            if (month == 12 || month == 1 || month == 2) Console.Write($"Зима ");
            else if (month == 3 || month == 4 || month == 5) Console.Write($"Весна ");
            else if (month == 6 || month == 7 || month == 8) Console.Write($"Лето ");
            else if (month == 9 || month == 10 || month == 11) Console.Write($"Осень ");

            if (day_of_week == 0) Console.Write($"Воскресенье");
            else if (day_of_week == 1) Console.Write($"Понедельник");
            else if (day_of_week == 2) Console.Write($"Вторник");
            else if (day_of_week == 3) Console.Write($"Среда");
            else if (day_of_week == 4) Console.Write($"Четверг");
            else if (day_of_week == 5) Console.Write($"Пятница");
            else if (day_of_week == 6) Console.Write($"Суббота"); 
#endif

            // Задание 6
            //Console.Write("Введите значение температуры: ");
            //int temp = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Для перевода температуры из градусов Цельсия в градусы Фаренгейта, нажмите 1\nДля перевода температуры из градусов Фаренгейта в градусы Цельсия, нажмите 2");
            //int choice = Int32.Parse(Console.ReadLine());

            //if (choice == 1)
            //{
            //    Console.WriteLine("Переводим из (C) в (F):");
            //    Console.WriteLine($"Температура {temp} градус -(а) -(ов) по Цельсию равна {temp * ((double)9 / 5) + 32} градус -(а) -(ов) по Фаренгейту");
            //}
            //if (choice == 2)
            //{
            //    Console.WriteLine("Переводим из (F) в (C):");
            //    Console.WriteLine($"Температура {temp} градус -(а) -(ов) по Цельсию равна {(temp - 32) * ((double)5 / 9)} градус -(а) -(ов) по Фаренгейту");
            //}


            // Задание 7
            //int start, end;
            //Console.Write("Введите начало диапазона: ");
            //start = Int32.Parse(Console.ReadLine());
            //Console.Write("Введите конец диапазона: ");
            //end = Int32.Parse(Console.ReadLine());
            //if (start > end)
            //{
            //    int buffer = start;
            //    start = end;
            //    end = buffer;
            //    Console.WriteLine("Проведена корректировка границ диапазона: ");
            //}
            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 2 == 0 && i < 9) Console.Write($"{i}  "); // хватило бы одного if, чисто для красоты вывода в консоль
            //    if (i % 2 == 0 && i > 9) Console.Write($"{i} ");
            //    if (i % 20 == 0) Console.WriteLine();
            //}


            Console.ReadLine();
        }
    }
}
