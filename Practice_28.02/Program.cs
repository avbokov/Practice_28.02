using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_28._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();    //  передаёт информацию в консоль
            //Console.ReadLine();     //  выводит информацию в консоль

            //Console.Write();
            //Console.WriteLine();
            //string a = @"Hello \n World";
            //string b = @"Hello \\n World";
            //string @string = "";

            //Console.Title = "Пример использования метода Title";
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Hello World");
            //Console.ReadLine();

            //int a = 15;
            //string a = "15";
            //int b = Convert.ToInt32(a); //  работает со всеми типами данных
            /*  ToBoolean
             *  ToByte
             *  ToChar
             *  Toint16/32/64
             *  ToString
            */
            //int c = Int32.Parse(a); //  работает только со строками
            //Console.WriteLine((float)a / 2);    //  явное преобразование
            //Console.ReadLine();

            //do
            //{
            //    // действие
            //}
            //while (условие);

            //for (; ; )
            //{ 

            //}
            //string a = "Hello World";
            //foreach (var i in a)
            //    Console.WriteLine(i);

            //int a = 15;
            //int b = 10;

            //if (a < b)
            //    Console.WriteLine(b);
            //else
            //    Console.WriteLine(a);

            //(a < b) ? Console.WriteLine(b) : Console.WriteLine(a);

            //Console.WriteLine((a < b) ? b : a);

            //string a = @"It's easy to win  
            //    forgiveness for \nbeing wrong;";      

            //Console.WriteLine("It's easy to win forgiveness for \nbeing wrong;\nbeing right is what gets you into \nreal trouble. \n\nBjarne Stroustrup");
            ////Console.ReadLine();

            //int num, summa = 0, max = 0, min = 0, proz = 1;
            ////  int? max = null; min = null

            //for (int i = 0; i < 5; i++)
            //{
            //    num = Int32.Parse(Console.ReadLine());
            //    if (i == 0) { min = max = num; }

            //    summa += num;

            //    if (num < min) min = num;
            //    if (num > max) max = num;

            //    proz *= num;
            //}
            //Console.WriteLine(summa);
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.WriteLine(proz);


            //int a = Int32.Parse(Console.ReadLine());
            //while (a > 0)
            //{ 
            //    Console.Write(a % 10);
            //    a /= 10;
            //}

            
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            //int fib1 = 0, fib2 = 1, fib3 = 0;

            //for (int i = 2; i < b; i++)
            //{
            //    fib3 = fib1 + fib2;
            //    fib1 = fib2;
            //    if(fib3 < b && fib3 > a) Console.WriteLine(fib3);
            //    fib2 = fib3;
            //}
            //Console.ReadLine();

           
                for (int fibNum1 = 0, fibNum2 = 1, step = 0; fibNum1 <= b || fibNum2 <= b; step++)
                {
                    if (step % 2 == 0)
                    {
                        if (fibNum1 >= a && fibNum1 <= b) Console.WriteLine(fibNum1);
                        fibNum1 += fibNum2;
                    }
                    else
                    { 
                        if (fibNum2 >= a && fibNum2 <= b) Console.WriteLine(fibNum2);
                        fibNum2 += fibNum1;
                    }
                }
            
            //Console.ReadLine();
        }
    }
}
