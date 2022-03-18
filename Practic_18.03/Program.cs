using System;
using static System.Console;
using System.Collections;   
using System.Collections.Generic;   //  урок про эти коллекции
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if false
namespace Practic_18._03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}

#endif

#if false
namespace Practic_18._03
{
    sealed class OperationTimer : IDisposable
    {
        long _startTime;
        string _text;
        int _CollectionCount;

        public OperationTimer(string text)
        {
            PrepareForOperation();
            _text = text;

            // сохраняется количество сборок мусора, выполненных в данный момент времени
            _CollectionCount = GC.CollectionCount(0);

            // сохраняется начальное время
            _startTime = Stopwatch.GetTimestamp();
        }

        public void Dispose()
        // отображает сколько времени прошло и сколько мусора было собрано за это время
        {
            WriteLine($"{_text}\t{(Stopwatch.GetTimestamp() - _startTime) / (double)Stopwatch.Frequency:0.00} " +
                $"секунды (сборка мусора {GC.CollectionCount(0) - _CollectionCount})");
        }

        private static void PrepareForOperation()
        // удаляются все неиспользуемые объекты
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

    }
    internal class Program
    {
        private static void ValueTypePerfTest()
        {
            const int COUNT = 10000000;
            using (new OperationTimer("List"))
            {
                List<int> list = new List<int>(COUNT);
                for (int n = 0; n < COUNT; n++)
                {
                    list.Add(n);
                    int x = list[n];
                }
                list = null;
            }

            using (new OperationTimer("ArrayList"))
            {
                ArrayList array = new ArrayList();
                for (int n = 0; n < COUNT; n++)
                {
                    array.Add(n);
                    int x = (int)array[n];
                }
                array = null;
            }
        }
        static void Main(string[] args)
        {
            //ArrayList arr = new ArrayList();
            //arr.Add();

            /*  необобщённые коллекции (без угловых скобок)
                обобщённые коллекции (с угловыми скобок)
                
            CollectionBase      Collection <T>
            ArrayList           List <T>
            HashTable           Dictionary <TKey, TValue>
            SortedList          SortedList <TKey, TValue>
            Stack               Stack <T>
            Queue               Queue <T>
                                LinkedList <T>
             */

            //List<int> listInt = new List<int> { 1, 2, 3 };
            // методы такие же, как и в обобщённых коллекциях
            //listInt.Add(2.4);

            ValueTypePerfTest();

            ReadKey();
        }
    }
}
#endif

#if false
namespace Practic_18._03
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Коллекция целых чисел");
            List<int> listInt = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                listInt.Add(random.Next(100));
            }

            foreach (int i in listInt)
            {
                Write(i + " ");
            }
            WriteLine("Коллекция строк");
            List<string> listString = new List<string>();
            listString.Add("Hello");
            listString.Add("World");
            listString.Add("!");

            foreach (string s in listString)
                Write(s + " ");

            Console.ReadKey();
        }
    }
}
#endif

#if false
namespace Practic_18._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> groups = new Dictionary<string, int>()
            { 
                ["GR1"] = 10,
                ["GR2"] = 13,
                ["GR3"] = 45
            };

            groups.Add("GR1", 10);
            groups.Add("GR2", 12);
            groups.Add("GR3", 5);
            groups["GR4"] = 4;

            groups["GR2"] = 50;

            WriteLine("Содержмое словаря");
            foreach (KeyValuePair<string, int> kp in groups)
            {
                WriteLine($"{kp.Key} {kp.Value}");
            }

            groups.Remove("GR4");

            try
            { 
                groups.Add("GR1", 19);
            }
            catch (ArgumentException e)
            {
                WriteLine(e.Message);
            }
            try
            {
                WriteLine(groups["GR8"]);
            }
            catch (KeyNotFoundException e)
            {
                WriteLine(e.Message);
            }
            int key;
            if (groups.TryGetValue("GR3", out key))
                WriteLine(key);
            else
                WriteLine("Такого ключа не существует");

            Console.ReadKey();
        }
    }
}
#endif

#if false
namespace Practic_18._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D<int> p1 = new Point2D<int>();
            WriteLine($"x = {p1.X} y = {p1.Y}");
            //WriteLine(typeof(Point2D<int>));
            WriteLine(p1);

            Point2D<double> p2 = new Point2D<double>(5.7, 6.48);
            WriteLine($"x = {p1.X} y = {p1.Y}");
            //WriteLine(typeof(Point2D<double>));
            WriteLine(p2);

            Console.ReadKey();
        }
    }
}
#endif

#if false
namespace Practic_18._03
{
    class GenericClass <T>
    {
        public void M1(T obj)
        {
            WriteLine($"Параметр {obj}");
        }
        public virtual void M2(T obj)
        {
            WriteLine($"Generic {obj}");
        }

    }

    class InheritClass : GenericClass<int>
    {
        public override void M2(int obj)
        {
            WriteLine($"Inherit {obj}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            InheritClass obj = new InheritClass();
            obj.M1(45);
            obj.M2(845);

            Console.ReadKey();
        }
    }
}
#endif

#if false
namespace Practic_18._03
{
    class BasicClass
    {
        protected int age;
    }

    class GenericClass<T> : BasicClass
    {
        public void M1(int obj)
        {
            age = 46;
            WriteLine($"Basic {age} Generic {obj}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> obj = new GenericClass<int>();
            obj.M1(49);           

            Console.ReadKey();
        }
    }
}
#endif

#if false
namespace Practic_18._03
{
    class A<T>
    {
        public class Inner { }        
    }
    class B<T>
    {
        public class Inner<U> { }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            A<int>.Inner a = new A<int>.Inner();
            WriteLine(a);
            A<double>.Inner a1 = new A<double>.Inner();
            WriteLine(a1);

            B<int>.Inner<string> b = new B<int>.Inner<string>();
            WriteLine(b);

            Console.ReadKey();
        }
    }
}
#endif

#if false
namespace Practic_18._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            where T: struct
            : class
            : new()
            :BaseClass
            : Interface

            общий синтаксис:
            class ИмяКласса <T> where T: ограничения

            class GenericClass <T> where T: class, IComparable, new(){}
            */

            Point2D<string> p = new Point2D<string>("0", "0");


            Console.ReadKey();
        }
    }
}
#endif

#if false
namespace Practic_18._03
{
    internal class Program
    {
        static T MaxElement<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (T i in arr)
            {
                if (i.CompareTo(max) > 0)
                    max = i;
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] arrInt = new int[] { 48, 74, 13, 98, 0, 44 };
            WriteLine($"Максимальный элемент {MaxElement <int>(arrInt)}");
            // рекомендуется явно указывать тип передаваемого значения

            double[] arrDouble = new double[] {12.4, 5.7, 63.07 };
            WriteLine($"Максимальный элемент {MaxElement(arrDouble)}");

            Console.ReadKey();
        }
    }
}

#endif

#if false
namespace Practic_18._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList auditory = new ArrayList
            List<Student> auditory = new List<Student> // везде использовать по возможности обощённые типы
            {
                new Student
                {
                    Firstname = "Иван",
                    Lastname = "Иванов",
                    BirthDate = new DateTime(1990,2,13)
                },
                new Student
                {
                    Firstname = "Пётр",
                    Lastname = "Петров",
                    BirthDate = new DateTime(1995, 6, 25)
                },
                new Student
                {
                    Firstname = "Лена",
                    Lastname = "Ленова",
                    BirthDate = new DateTime(1994, 10, 23)
                },
            };

            WriteLine("Список студентов");
            foreach (Student student in auditory)
                WriteLine(student);

            WriteLine("Сортировка по фамилии");
            auditory.Sort();
            foreach (Student student in auditory)
                WriteLine(student);

            WriteLine("Сортировка по дате рождения");
            auditory.Sort(new DateComparer());
            foreach (Student student in auditory)
                WriteLine(student);

            Console.ReadKey();
        }
    }
}
#endif

#if true
namespace Practic_18._03
{
    interface ICalc<T>
    {
        T Sum(T b);
    }
    internal class Program
    {
        class CalcInt : ICalc<CalcInt>
        {
            int _number = 0;
            public CalcInt(int n)
            {
                _number = n;
            }
            public CalcInt Sum (CalcInt b)
            {
                return new CalcInt(_number + b._number);
            }
            public override string ToString()
            {
                return _number.ToString();
            }

        }
        class MyList<T> where T : ICalc<T>
        {
            List<T> list = new List<T>();

            public void Add(T t)
            {
                list.Add(t);
            }
            public T Sum()
            {
                if (list.Count == 0)
                    return default(T);
                T result = list[0];

                for (int i = 1; i < list.Count; i++)
                    result = result.Sum(list[i]);

                return result;
            }
        }
        static void Main(string[] args)
        {
            MyList<CalcInt> myList = new MyList<CalcInt>();
            myList.Add(new CalcInt(10));
            myList.Add(new CalcInt(20));
            myList.Add(new CalcInt(30));

            WriteLine($"Сумма элементов = {myList.Sum()}");

            Console.ReadKey();
        }
    }
}
#endif