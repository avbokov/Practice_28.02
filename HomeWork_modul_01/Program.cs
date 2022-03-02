using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_modul_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите число от 1 до 100: \n");
            //int a = Int32.Parse(Console.ReadLine());
            //if (a % 3 == 0 && a % 5 == 0) Console.WriteLine("Fizz Buzz");
            //else if (a % 3 == 0) Console.WriteLine("Fizz");
            //else if (a % 5 == 0) Console.WriteLine("Buzz");
            //else Console.WriteLine(a);

            Console.Write("Введите число: ");
            int a = Int32.Parse(Console.ReadLine());
            //int a = Console.ReadLine();
            Console.Write("Введите процент: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write(b);
            Console.Write(" % от числа ");
            Console.Write(a);
            Console.Write(" равно: ");
            int c = ((a / 100)*b);
            Console.WriteLine(c);
        }
    }
}
