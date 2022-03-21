using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if false
namespace Practic_21._03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
} 
#endif

#if false
namespace Practic_21._03
{
    class Student
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Фамилия: {LastName} Имя: {FirstName}\n " +
                $"Дата: {BirthDate.ToLongDateString()}";
        }
    }

    class Auditory
    {
        List<Student> auditory = new List<Student>
        {
            new Student
            { 
                FirstName = "Иван",
                LastName = "Иванов",
                BirthDate = new DateTime (1999, 3, 24)
            },
            new Student
            {
                FirstName = "Пётр",
                LastName = "Петров",
                BirthDate = new DateTime (1997, 5, 16)
            },
            new Student
            {
                FirstName = "Лена",
                LastName = "Ленова",
                BirthDate = new DateTime (1995, 12, 17)
            },
        };

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < auditory.Count; i++)
                yield return auditory[i];
        }
    }

    /*
     public IEnumerable имя_итератора (список_параметров)
    {
    // код
    yield return возвращаемое значение
    }

     */

    class Program
    {
        static void Main(string[] args)
        {
            //// yield ключевое слово. Итераторы.
            //Auditory auditory = new Auditory();
            //foreach (Student student in auditory)
            //    Console.WriteLine(student);

            Console.WriteLine("Введите начальное значение:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное значение:");
            int end = int.Parse(Console.ReadLine());

            NameIterator nameIterator = new NameIterator(end);

            Console.WriteLine("Все значения:");
            foreach (int i in nameIterator)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            Console.WriteLine("Значение в заданном диапазоне:");
            foreach (int i in nameIterator.GetRange(start))
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}
#endif

// Новая тема: ДЕЛЕГАТЫ
#if false
namespace Practic_21._03
{
    /*
    Clone()
    Combine(Delegate, Delegate)
    CreateDelegate(Type, MethodInfo) создаёт делегат указанного типа
    Delegate Remove(Delegate, Delegate)
    bool operator == (Delegate, Delegate)
    bool operator != (Delegate, Delegate)
     */
    public delegate double CalcDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y) { return x + y; }
        public double Sub(double x, double y) { return x - y; }
        public double Mult(double x, double y) { return x * y; }
        public double Div(double x, double y)
        {
            if (y != 0)
                return x / y;
            throw new DivideByZeroException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Делегат - безопасный ссылочный тип, позволяющий хранить ссылки на метод заданной сигнатуры
            // и с их помощью вызывать эти методы

            Calculator calculator = new Calculator();
            WriteLine("Введите выражение:");
            string exp = ReadLine();
            char sign = ' ';
            foreach (char c in exp)
                if (c == '+' || c == '-' || c == '*' || c == '/') 
                {
                    sign = c;
                    break;
                }

            string[] numbers = exp.Split(sign);

            CalcDelegate del = null;
            switch (sign)
            {
                case '+':
                    del = new CalcDelegate(calculator.Add);
                    break;
                case '-':
                    del = new CalcDelegate(calculator.Sub);
                    break;
                case '*':
                    //del = new CalcDelegate(calculator.Mult); // или так или так
                    del = calculator.Mult;
                    break;
                case '/':
                    del = new CalcDelegate(calculator.Div);
                    break;
                default:
                    throw new InvalidOperationException();
            }

            WriteLine($"{del(double.Parse(numbers[0]), double.Parse(numbers[1]))}");

            Console.ReadKey();
        }
    }
}
#endif

#if false
namespace Practic_21._03
{
    /*
    Clone()
    Combine(Delegate, Delegate)
    CreateDelegate(Type, MethodInfo) создаёт делегат указанного типа
    Delegate Remove(Delegate, Delegate)
    bool operator == (Delegate, Delegate)
    bool operator != (Delegate, Delegate)
     */
    public delegate double CalcDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y) { return x + y; }
        public double Sub(double x, double y) { return x - y; }
        public double Mult(double x, double y) { return x * y; }
        public double Div(double x, double y)
        {
            if (y != 0)
                return x / y;
            throw new DivideByZeroException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //// Делегат - безопасный ссылочный тип, позволяющий хранить ссылки на метод заданной сигнатуры
            //// и с их помощью вызывать эти методы

            //Calculator calculator = new Calculator();
            //CalcDelegate calcAll = null;
            ////CalcDelegate calcDiv = calculator.Div;

            //calcAll += calculator.Div;
            //calcAll += calculator.Add;
            //calcAll += calculator.Sub;

            //foreach (CalcDelegate i in calcAll.GetInvocationList())
            //{
            //    try 
            //    {
            //        WriteLine($"{ i(5.7, 3.2)}");                
            //    }
            //    catch (Exception e)
            //    {
            //        WriteLine(e.Message);
            //    }
            //}

            Class2 class2 = new Class2();
            AddDelegate<int> delegateInt = class2.AddInt;
            WriteLine($"Сумма целых чисел: {delegateInt(8, 6)}");

            AddDelegate<double> delegateDouble = class2.AddDouble;
            WriteLine($"Сумма вещественных чисел: {delegateDouble(4.7, 0.8)}");

            AddDelegate<char> delegateChar = Class2.AddChar;
            WriteLine($"Сумма символов: {delegateChar('S', 'h')}");

            
            //Action<T>
            //    List<T>
            

            Console.ReadKey();
        }
    }
}
#endif

// Делегат Action
#if false
namespace Practic_21._03
{
    class Student
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Фамилия: {LastName} Имя: {FirstName}\n " +
                $"Дата: {BirthDate.ToLongDateString()}";
        }
    }   

    internal class Program
    {
        static void FullName(Student student)
        {
            WriteLine($"{student.FirstName} {student.LastName}");
        }
        static void Main(string[] args)
        {           

            List<Student> auditory = new List<Student>
        {
            new Student
            {
                FirstName = "Иван",
                LastName = "Иванов",
                BirthDate = new DateTime (1999, 3, 24)
            },
            new Student
            {
                FirstName = "Пётр",
                LastName = "Петров",
                BirthDate = new DateTime (1997, 5, 16)
            },
            new Student
            {
                FirstName = "Лена",
                LastName = "Ленова",
                BirthDate = new DateTime (1995, 12, 17)
            },
        };
            WriteLine("Список студентов");
            auditory.ForEach(FullName);

            Console.ReadKey();

            // Func делегат
            
        }
    }
}
#endif

// Делегат Func работает с IEnumerable
#if false
namespace Practic_21._03
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Фамилия: {LastName} Имя: {FirstName}\n " +
                $"Дата: {BirthDate.ToLongDateString()}";
        }
    }

    internal class Program
    {
        static string FullName(Student student)
        {
            return $"{student.FirstName} {student.LastName}";
        }
        static void Main(string[] args)
        {

            List<Student> auditory = new List<Student>
        {
            new Student
            {
                FirstName = "Иван",
                LastName = "Иванов",
                BirthDate = new DateTime (1999, 3, 24)
            },
            new Student
            {
                FirstName = "Пётр",
                LastName = "Петров",
                BirthDate = new DateTime (1997, 5, 16)
            },
            new Student
            {
                FirstName = "Лена",
                LastName = "Ленова",
                BirthDate = new DateTime (1995, 12, 17)
            },
        };
            WriteLine("Список студентов");
            IEnumerable<string> students = auditory.Select(FullName);
            foreach (string student in students)
                WriteLine(student);


            Console.ReadKey();

            // Func делегат

        }
    }
}
#endif

// Делегат Predicate
#if false
namespace Practic_21._03
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Фамилия: {LastName} Имя: {FirstName}\n " +
                $"Дата: {BirthDate.ToLongDateString()}";
        }
    }

    internal class Program
    {
        static bool OnlySpring(Student student)
        {
            return student.BirthDate.Month >= 3 && student.BirthDate.Month <= 5;
        }

        static void Main(string[] args)
        {

            List<Student> auditory = new List<Student>
        {
            new Student
            {
                FirstName = "Иван",
                LastName = "Иванов",
                BirthDate = new DateTime (1999, 3, 24)
            },
            new Student
            {
                FirstName = "Пётр",
                LastName = "Петров",
                BirthDate = new DateTime (1997, 5, 16)
            },
            new Student
            {
                FirstName = "Лена",
                LastName = "Ленова",
                BirthDate = new DateTime (1998, 12, 17)
            },
        };           

            List<Student> students = auditory.FindAll(OnlySpring);
            foreach (Student student in students)
                WriteLine(student);

            Console.ReadKey();           

        }
    }
}
#endif

// Делегат Comparison
#if false
namespace Practic_21._03
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Фамилия: {LastName} Имя: {FirstName}\n " +
                $"Дата: {BirthDate.ToLongDateString()}";
        }
    }

    internal class Program
    {
        static int SortBirthDate(Student student1, Student student2)
        {
            return student1.BirthDate.CompareTo(student2.BirthDate);
        }

        static void Main(string[] args)
        {

            List<Student> auditory = new List<Student>
        {
            new Student
            {
                FirstName = "Иван",
                LastName = "Иванов",
                BirthDate = new DateTime (1999, 3, 24)
            },
            new Student
            {
                FirstName = "Пётр",
                LastName = "Петров",
                BirthDate = new DateTime (1997, 5, 16)
            },
            new Student
            {
                FirstName = "Лена",
                LastName = "Ленова",
                BirthDate = new DateTime (1998, 12, 17)
            },
        };

            auditory.Sort(SortBirthDate);
            foreach (Student student in auditory)
                WriteLine(student);

            Console.ReadKey();

        }
    }
}
#endif

// События
#if false
namespace Practic_21._03
{
    public delegate void ExamDelegate(string t);
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public void Exam(string task)
        {
            WriteLine($"Фамилия: {LastName} Имя: {FirstName}\n " +
                $"задача {task}");
        }
    }
    class Teacher
    {
        public event ExamDelegate examevent;
        public void Exam(string task)
        {
            if (examevent != null)
                examevent(task);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> auditory = new List<Student>
        {
            new Student
            {
                FirstName = "Иван",
                LastName = "Иванов",
                BirthDate = new DateTime (1999, 3, 24)
            },
            new Student
            {
                FirstName = "Пётр",
                LastName = "Петров",
                BirthDate = new DateTime (1997, 5, 16)
            },
            new Student
            {
                FirstName = "Лена",
                LastName = "Ленова",
                BirthDate = new DateTime (1998, 12, 17)
            },
        };

            Teacher teacher = new Teacher();
            foreach (Student student in auditory)
                teacher.examevent += student.Exam;

            teacher.Exam("Решена");

            // [модификатор_доступа] event ИмяДелегата ИмяСобытия;

            Console.ReadKey();

        }
    }
}
#endif

// События
#if true
namespace Practic_21._03
{
    public delegate void ExamDelegate(string t);
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public void Exam(string task)
        {
            WriteLine($"Фамилия: {LastName} Имя: {FirstName}\n " +
                $"задача {task}");
        }
    }
    class Teacher
    {
        public ExamDelegate examevent;
        public void Exam(string task)
        {
            if (examevent != null)
                examevent(task);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> auditory = new List<Student>
        {
            new Student
            {
                FirstName = "Иван",
                LastName = "Иванов",
                BirthDate = new DateTime (1999, 3, 24)
            },
            new Student
            {
                FirstName = "Пётр",
                LastName = "Петров",
                BirthDate = new DateTime (1997, 5, 16)
            },
            new Student
            {
                FirstName = "Лена",
                LastName = "Ленова",
                BirthDate = new DateTime (1998, 12, 17)
            },
        };

            Teacher teacher = new Teacher();
            foreach (Student student in auditory)
                teacher.examevent += student.Exam;

            teacher.examevent.Invoke("никто не пришёл");

            teacher.examevent = null;

            teacher.Exam("Решена");
            
            Console.ReadKey();

        }
    }
}
#endif
