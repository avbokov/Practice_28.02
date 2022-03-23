using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if false
namespace Practic_23._03
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
namespace Practic_23._03
{
    //public event NameDelegate NameEvent() синтаксис по объявлению событий, без делегата не объявить
    // можно с использованием обобщенного делегата
    class ExamEventArgs : EventArgs
    { 
    public string Task { get; set; }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void Exam(object task, ExamEventArgs e)
        {
            WriteLine($"Фамилия: {LastName} Имя: {FirstName}\n " +
            $"задача: {e.Task}");
        }
    }
    class Teacher
    {
        public EventHandler<ExamEventArgs> examEvent;
        public void Exam(ExamEventArgs task)
        {
            if (examEvent != null)
                examEvent(this, task);
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
                BirthDate = new DateTime(1999, 3, 24)
                },
                new Student
                {
                FirstName = "Петр",
                LastName = "Петров",
                BirthDate = new DateTime(1997, 5, 16)
                },
                new Student
                {
                FirstName = "Елена",
                LastName = "Еленова",
                BirthDate = new DateTime(1998, 8, 01)
                },
            };

            Teacher teacher = new Teacher();
            foreach (Student student in auditory)
                teacher.examEvent += student.Exam;

            ExamEventArgs e = new ExamEventArgs { Task = "решено" };
            teacher.Exam(e);

            ReadKey();
        }
    }    
} 
#endif

#if false
namespace Practic_23._03
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
            $"задача: {task}");
        }
    }
    class Teacher
    {
        public event ExamDelegate examEvent;
        public void Exam(string task)
        {
            if (examEvent != null)
                examEvent(task);
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
                BirthDate = new DateTime(1999, 3, 24)
                },
                new Student
                {
                FirstName = "Петр",
                LastName = "Петров",
                BirthDate = new DateTime(1997, 5, 16)
                },
                new Student
                {
                FirstName = "Елена",
                LastName = "Еленова",
                BirthDate = new DateTime(1998, 8, 01)
                },
            };

            Teacher teacher = new Teacher();
            Student student = new Student();

            teacher.examEvent += student.Exam;
            teacher.examEvent += student.Exam;
            //teacher.examEvent += student.Exam;
            teacher.examEvent += student.Exam;
            teacher.examEvent -= student.Exam;

            teacher.Exam("решена");

            // [модификатор_доступа] event ИмяДелегата ИмяСобытия
            // {
            //      add { код добавления события в цепочку событий }
            //      remove { код удаления события в цепочку событий }
            // }


            ReadKey();
        }
    }    
}
#endif

#if false
namespace Practic_23._03
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
            $"задача: {task}");
        }
    }
    class Teacher
    {
        SortedList<int, ExamDelegate> _sortedList = new SortedList<int, ExamDelegate>();
        Random _rand = new Random();
        public event ExamDelegate examEvent
        { 
            add
            {
                for (int key; ;)
                {
                    key = _rand.Next();
                    if (!_sortedList.ContainsKey(key))
                    {
                        _sortedList.Add(key, value);
                        break;
                    }
                }
            }
            remove
            {
                _sortedList.RemoveAt(_sortedList.IndexOfValue(value));
            }
        }
        public void Exam(string task)
        {
            foreach (int key in _sortedList.Keys)
            { 
                if (_sortedList[key] != null)
                    _sortedList[key](task);            
            }
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
                BirthDate = new DateTime(1999, 3, 24)
                },
                new Student
                {
                FirstName = "Петр",
                LastName = "Петров",
                BirthDate = new DateTime(1997, 5, 16)
                },
                new Student
                {
                FirstName = "Елена",
                LastName = "Еленова",
                BirthDate = new DateTime(1998, 8, 01)
                },
            };

            Teacher teacher = new Teacher();
            foreach (Student i in auditory)
                teacher.examEvent += i.Exam;

            Student student = new Student()
            {
                FirstName = "Александр",
                LastName = "Александров",
                BirthDate = new DateTime (1980, 12, 12)
            };

            teacher.examEvent += student.Exam;
            teacher.Exam("Решена 1");
            WriteLine();
            teacher.examEvent -= student.Exam;
            teacher.Exam("Решена 2");
            WriteLine();

            // [модификатор_доступа] event ИмяДелегата ИмяСобытия
            // {
            //      add { код добавления события в цепочку событий }
            //      remove { код удаления события в цепочку событий }
            // }

            ReadKey();
        }
    }
}
#endif

// анонимный метод
#if false
namespace Practic_23._03
{
    // delegate [(параметры)] { // выполняемый код
    // } - объявление анонимного метода

    public delegate void ExamDelegate(string t);

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void Exam(string task)
        {
            WriteLine($"Фамилия: {LastName} Имя: {FirstName}\n " +
            $"задача: {task}");
        }
    }
    class Teacher
    {
        SortedList<int, ExamDelegate> _sortedList = new SortedList<int, ExamDelegate>();
        Random _rand = new Random();
        public event ExamDelegate examEvent
        {
            add
            {
                for (int key; ;)
                {
                    key = _rand.Next();
                    if (!_sortedList.ContainsKey(key))
                    {
                        _sortedList.Add(key, value);
                        break;
                    }
                }
            }
            remove
            {
                _sortedList.RemoveAt(_sortedList.IndexOfValue(value));
            }
        }
        public void Exam(string task)
        {
            foreach (int key in _sortedList.Keys)
            {
                if (_sortedList[key] != null)
                    _sortedList[key](task);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Student> auditory = new List<Student>
            //{
            //    new Student
            //    {
            //    FirstName = "Иван",
            //    LastName = "Иванов",
            //    BirthDate = new DateTime(1999, 3, 24)
            //    },
            //    new Student
            //    {
            //    FirstName = "Петр",
            //    LastName = "Петров",
            //    BirthDate = new DateTime(1997, 5, 16)
            //    },
            //    new Student
            //    {
            //    FirstName = "Елена",
            //    LastName = "Еленова",
            //    BirthDate = new DateTime(1998, 8, 01)
            //    },
            //};

            //Teacher teacher = new Teacher();
            //foreach (Student i in auditory)
            //    teacher.examEvent += i.Exam;

            //Student student = new Student()
            //{
            //    FirstName = "Александр",
            //    LastName = "Александров",
            //    BirthDate = new DateTime(1980, 12, 12)
            //};

            //teacher.examEvent += student.Exam;
            //teacher.Exam("Решена 1");
            //WriteLine();
            //teacher.examEvent -= student.Exam;
            //teacher.Exam("Решена 2");
            //WriteLine();

            // [модификатор_доступа] event ИмяДелегата ИмяСобытия
            // {
            //      add { код добавления события в цепочку событий }
            //      remove { код удаления события в цепочку событий }
            // }

            WriteLine("Использование события");
            Dispatcher dispatcher = new Dispatcher();
            dispatcher.eventDouble += delegate (double a, double b)
            {
                if (b != 0)
                    return a / b;
                throw new DivideByZeroException();
            };

            double n1 = 7.4, n2 = 3.2;

            WriteLine($"{n1}/{n2} = {dispatcher.OnEventDouble(n1,n2)}");

            WriteLine("Использование локальной переменной");
            int number = 5;

            dispatcher.eventVoid += delegate(int n)
            {
                WriteLine($"{number} + {n} = {number + n}");
            };

            dispatcher.OnEventVoid();
            dispatcher.OnEventVoid(6);

            WriteLine("Использование делегата");

            AnonimDelegateVoid voidDelegate = new AnonimDelegateVoid(delegate { WriteLine("Ok!"); });

            voidDelegate += delegate { WriteLine("Bye!"); };

            voidDelegate();

            ReadKey();
        }
    }
}
#endif

// лямбда-выражения
#if false
namespace Practic_23._03
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
            $"задача: {task}");
        }
    }
    class Teacher
    {
        SortedList<int, ExamDelegate> _sortedList = new SortedList<int, ExamDelegate>();
        Random _rand = new Random();
        public event ExamDelegate examEvent
        {
            add
            {
                for (int key; ;)
                {
                    key = _rand.Next();
                    if (!_sortedList.ContainsKey(key))
                    {
                        _sortedList.Add(key, value);
                        break;
                    }
                }
            }
            remove
            {
                _sortedList.RemoveAt(_sortedList.IndexOfValue(value));
            }
        }
        public void Exam(string task)
        {
            foreach (int key in _sortedList.Keys)
            {
                if (_sortedList[key] != null)
                    _sortedList[key](task);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Student> auditory = new List<Student>
            //{
            //    new Student
            //    {
            //    FirstName = "Иван",
            //    LastName = "Иванов",
            //    BirthDate = new DateTime(1999, 3, 24)
            //    },
            //    new Student
            //    {
            //    FirstName = "Петр",
            //    LastName = "Петров",
            //    BirthDate = new DateTime(1997, 5, 16)
            //    },
            //    new Student
            //    {
            //    FirstName = "Елена",
            //    LastName = "Еленова",
            //    BirthDate = new DateTime(1998, 8, 01)
            //    },
            //};

            //Teacher teacher = new Teacher();
            //foreach (Student i in auditory)
            //    teacher.examEvent += i.Exam;

            //Student student = new Student()
            //{
            //    FirstName = "Александр",
            //    LastName = "Александров",
            //    BirthDate = new DateTime(1980, 12, 12)
            //};

            //teacher.examEvent += student.Exam;
            //teacher.Exam("Решена 1");
            //WriteLine();
            //teacher.examEvent -= student.Exam;
            //teacher.Exam("Решена 2");
            //WriteLine();

            // [модификатор_доступа] event ИмяДелегата ИмяСобытия
            // {
            //      add { код добавления события в цепочку событий }
            //      remove { код удаления события в цепочку событий }
            // }

            WriteLine("Использование события");
            Dispatcher dispatcher = new Dispatcher();
            dispatcher.eventDouble += (double a, double b) =>
            {
                if (b != 0)
                    return a / b;
                throw new DivideByZeroException();
            };

            double n1 = 7.4, n2 = 3.2;

            WriteLine($"{n1}/{n2} = {dispatcher.OnEventDouble(n1, n2)}");

            WriteLine("Использование локальной переменной");
            int number = 5;

            // dispatcher.eventVoid += (n) =>    можно ставить или не ставить скобки, если параметр всего один
            // dispatcher.eventVoid += n =>
            {
                WriteLine($"{number} + {n} = {number + n}");
            };

            dispatcher.OnEventVoid();
            dispatcher.OnEventVoid(6);

            WriteLine("Использование делегата");

            AnonimDelegateVoid voidDelegate = new AnonimDelegateVoid(() => { WriteLine("Ok!"); });

            voidDelegate += () => { WriteLine("Bye!"); };

            voidDelegate();

            ReadKey();

            //  (параметры) => {// код, который использует параметры;
            //                  }
        }
    }
}
#endif

#if false
namespace Practic_23._03
{

    public delegate void ExamDelegate(string t);

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"Фамилия: {LastName} Имя: {FirstName}\n " +
            $"дата рождения: {BirthDate.ToLongDateString()}";
        }
    }    

    internal class Program
    {
        class ExampCalc
        {
            public string CurrentDate => $"Текущее время " +
                        $"{DateTime.Now.ToLongDateString()}";
            public int AddInt(int x, int y) => x + y;
            public static void AddVoid(int x, int y) =>
                WriteLine($"{x} + {y} = {x + y}");
        }
        static void Main(string[] args)
        {
            List<Student> auditory = new List<Student>
            {
                new Student
                {
                FirstName = "Иван",
                LastName = "Иванов",
                BirthDate = new DateTime(1999, 3, 24)
                },
                new Student
                {
                FirstName = "Петр",
                LastName = "Петров",
                BirthDate = new DateTime(1997, 5, 16)
                },
                new Student
                {
                FirstName = "Елена",
                LastName = "Еленова",
                BirthDate = new DateTime(1998, 8, 01)
                },
            };

            ExampCalc exampCalc = new ExampCalc();
            WriteLine(exampCalc.CurrentDate);
            try 
            {
                Write("Введите число: ");
                int n1 = int.Parse(ReadLine());

                Write("Введите число: ");
                int n2 = int.Parse(ReadLine());

                WriteLine($"{n1} + {n2} = {exampCalc.AddInt(n1, n2)}");

                ExampCalc.AddVoid(n1, n2);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            ReadKey();
            
        }
    }
}
#endif

// исключения
#if true
namespace Practic_23._03
{

    public delegate void ExamDelegate(string t);

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"Фамилия: {LastName} Имя: {FirstName}\n " +
            $"дата рождения: {BirthDate.ToLongDateString()}";
        }
    }    

    internal class Program
    {
        class ExampCalc
        {
            public string CurrentDate => $"Текущее время " +
                        $"{DateTime.Now.ToLongDateString()}";
            public int AddInt(int x, int y) => x + y;
            public static void AddVoid(int x, int y) =>
                WriteLine($"{x} + {y} = {x + y}");
        }
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.DividByZero();

            ReadKey();
            
        }
    }
}
#endif
