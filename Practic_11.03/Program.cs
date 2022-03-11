using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if false
namespace Practic_11._03
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
} 
#endif

#if false
namespace Practic_11._03
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static Point operator ++(Point a)
        {
            a.X++;
            a.Y++;
            return a;
        }
        public static Point operator --(Point a)
        {
            a.X--;
            a.Y--;
            return a;
        }
        public static Point operator -(Point a)
        {
            return new Point { X = -a.X, Y = -a.Y };
        }
        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            /*
                можно перегрузить
             -
            !
            ~
            ++ --
            true false
            + - * / %
            & | ^ << >>
            == != < > <= >=
            && ||
            []
            ()

                нельзя перегрузить
            += -= *= /= %= &= |= ^= <<= >>=
            =
            .
            ?:
            new
            as is typeof
            -> sizeof * &
             */

            // основной синтаксис
            //public static тип_возврата operator символ_операции (параметры) {}

            Point point = new Point { X = 10, Y = 10 };

            WriteLine($"Исходная точка\n{point}");

            WriteLine(++point);
            WriteLine(point++);

            WriteLine(--point);
            WriteLine(-point);

            WriteLine($"Исходная точка\n{point}");
            ReadKey();

        }
    }
} 
#endif

#if false
namespace Practic_11._03
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vector()
        {
            // пустой конструктор
        }
        public Vector(Point begin, Point end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X - v2.X, Y = v1.Y - v2.Y };
        }
        public static Vector operator *(Vector v, int n)
        {
            v.X *= n;
            v.Y *= n;
            return v;
        }
        public static Vector operator *(int n, Vector v)
        {
            return v * n;
        }
        public override string ToString()
        {
            return $"Vector: X = {X}, Y = {Y}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point { X = 2, Y = 3 };
            Point point2 = new Point { X = 4, Y = 5 };

            Vector vector1 = new Vector(point1, point2);
            Vector vector2 = new Vector { X = 2, Y = 3 };

            WriteLine($"Вектора\n{vector1}\n{vector2}");

            WriteLine($"Сложение векторов\n{vector1 + vector2}");
            WriteLine($"Разность векторов\n{vector1 - vector2}");

            int n = int.Parse(ReadLine());
            vector1 *= n;

            WriteLine($"Умножение вектора на число\n{vector1}");

            ReadKey();
        }
    }
} 
#endif

#if false
namespace Practic_11._03
{    
        /*
         == !=
        < >
        <= >=
        */
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1 { X = 10, Y = 10};
            Class1 class2 = class1;
            Class1 class3 = new Class1 { X = 10, Y = 10};

            WriteLine($"ReferenceEquals(class1, class2) = " +
                $"{ReferenceEquals(class1, class2)}");

            WriteLine($"ReferenceEquals(class1, class3) = " +
                $"{ReferenceEquals(class1, class3)}");

            Class2 class4 = new Class2 { X = 10, Y = 10 };
            Class2 class5 = new Class2 { X = 10, Y = 10 };

            WriteLine($"ReferenceEquals(class4, class4) = " +
               $"{ReferenceEquals(class4, class4)}");

            WriteLine($"Equals(class1, class3) = " +
               $"{Equals(class1, class3)}");

            WriteLine($"Equals(class4, class5) = " +
               $"{Equals(class4, class5)}");

            ReadKey();

        }
    }
} 
#endif

#if false
namespace Practic_11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point { X = 10, Y = 10 };
            Point point2 = new Point { X = 20, Y = 20 };

            WriteLine($"point1: {point1}");
            WriteLine($"point2: {point2}");

            WriteLine($"point1 == point2: {point1 == point2}");
            WriteLine($"point1 != point2: {point1 != point2}");

            WriteLine($"point1 > point2: {point1 > point2}");
            WriteLine($"point1 < point2: {point1 < point2}");
        }
    }
} 
#endif

#if false
namespace Practic_11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Point1 point1 = new Point1 { X = 0, Y = 0 };
            if (point1)
            {
                WriteLine("Точка не в начале координат");
            }
            else
            {
                WriteLine("Точка в начале координат");
            }


            ReadKey();

        }
    }
} 
#endif

#if false
namespace Practic_11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Point1 point1 = new Point1 { X = 10, Y = 10 };
            Point1 point2 = new Point1 { X = 0, Y = 0 };

            WriteLine($"point1: {point1}\npoint2: {point2}");

            Write($"point1 && point 2: ");

            if (point1 && point2)
                WriteLine("true");
            else
                WriteLine("false");

            Write($"point1 || point 2: ");

            if (point1 || point2)
                WriteLine("true");
            else
                WriteLine("false");

            ReadKey();

        }
    }
} 
#endif

#if true
namespace Practic_11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle { Width = 5, Height = 10 };

            Square square = new Square { Length = 7 };

            Rectangle rectSquare = square;

            WriteLine($"Неявное преобразование (implicit) квадрата ({square}) " +
                $"к прямоугольнику.\n{rectSquare}");
            rectSquare.Draw();

            Square squareRect = (Square)rect;
            WriteLine($"Явное преобразование (explicit) прямоугольника ({rect}) " +
               $"к квадрату.\n{squareRect}");
            squareRect.Draw();

            int number = 12;

            Square squareInt = number;
            WriteLine($"Неявное преобразование числа {number} к квадрату.\n{squareRect}" +
                $"{squareInt}");
            squareInt.Draw();

            number = (int)square;
            WriteLine($"Явное преобразование квадрата {square} к числу\n" +
            $"{number}");

            ReadKey();
        }
    }
} 
#endif