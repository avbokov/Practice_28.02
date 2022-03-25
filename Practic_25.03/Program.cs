using System;
// using System.GC;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if false
namespace Practic_25._03
{
    class Program
    {
        static void Main(string[] args)
        {

             ReadLine();
        }
    }
} 
#endif

#if false
namespace Practic_25._03
{
    public class MyException : ApplicationException
    {
        public DateTime TimeException { get;  private set; }
        public MyException() : base("моё исключение")
        {
            TimeException = DateTime.Now;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // явная генерация исключений
            // throw new NotImplementedException();

            int n1, n2, res = 0;
            try
            {
                n1 = int.Parse(ReadLine());
                n2 = int.Parse(ReadLine());
                res = n1 / n2;

                if (res % 2 != 0)
                {
                    throw new MyException();
                }
                WriteLine($"результат деления: {res}");
            }
            //catch (MyException e)
            catch (DivideByZeroException e)
            {
                WriteLine(e.Message);
                // WriteLine(e.TimeException);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }

            ReadLine();
        }
    }
} 
#endif

#if false
namespace Practic_25._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int n = 0;
            try
            {
                for (int i = -3; i <= 3; i++)
                {
                    try
                    {
                        arr[n] = 100 / i;
                        WriteLine(arr[n]);
                        n++;
                    }
                    catch (DivideByZeroException e)
                    {
                        WriteLine("Внутренний catch");
                        WriteLine(e.Message);
                    }
                }
            }
            catch(IndexOutOfRangeException e)
            {
                WriteLine("Внешинй catch");
                WriteLine(e.Message);
            }

            ReadLine();
        }
    }
} 
#endif

// повторно генерировать исключения
#if false
namespace Practic_25._03
{
    internal class Program
    {
        static int DivideByZero(int n1, int n2)
        {
            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException e)
            {
                //throw;
                throw new Exception("Дополнительная информация", e);
            }

            return result;
        }
        static void Main(string[] args)
        {
            int n1, n2, res = 0;

            try
            {
                n1 = int.Parse(ReadLine());
                n2 = int.Parse(ReadLine());
                res = DivideByZero(n1, n2);
                WriteLine(res);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                WriteLine(e.InnerException.Message);
            }

            ReadLine();
        }
    }
} 
#endif

// перехват по стеку StackTrace
#if false
namespace Practic_25._03
{
    class Program
    {
        static void f2()
        {
            throw new Exception("Моё исключение");
        }
        static void f1()
        {
            f2();
        }
        static void f()
        {
            try
            {
                f1();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                WriteLine(ex.StackTrace);
            }
        }
        static void Main(string[] args)
        {
            f();

             ReadLine();
        }
    }
} 
#endif

#if false
namespace Practic_25._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // checked - задаёт режим контроля переполнения
            // unchecked - что-то там игнорирует...

            //byte a = 100;
            //a = (byte)(a + 200);
            //WriteLine((int)a);

            //int b = 65536;
            //short s = (short)b;
            //WriteLine(s);

            byte b = 255;
            try
            {
                checked
                {
                    b++;
                }
                WriteLine(b);
            }
            catch (OverflowException ex)
            {
                WriteLine(ex.Message);
            }

            try
            {
                unchecked
                {
                    b++;
                }
                WriteLine(b);
            }
            catch (OverflowException e)
            {
                WriteLine(e.Message);
            }

            ReadLine();
        }
    }
} 
#endif

#if false
namespace Practic_25._03
{
    class Program
    {
        static void Main(string[] args)
        {            
            byte b = 100;
            WriteLine(unchecked((byte)(b + 200)));
            try
            {
                checked
                {
                    b++;
                }
                WriteLine(checked((byte)(b + 200)));
            }
            catch (OverflowException ex)
            {
                WriteLine(ex.Message);
            }            

            ReadLine();
        }
    }
} 
#endif

#if false
namespace Practic_25._03
{
    class Program
    {
        static int DivisionNumbers(int n1, int n2)
        {
            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException e)
            {
                throw new Exception("Проверка фильтров исключения", e);
            }
            return result;
        }
        static void Main(string[] args)
        {
            // синтаксис объявления дополнительного фильтра
            //try
            //{

            //}
            //catch (тип_исключения) when (условие) { }

            int n1, n2, res = 0;
            try
            {
                n1 = int.Parse(ReadLine());
                n2 = int.Parse(ReadLine());
                res = DivisionNumbers(n1, n2);

                WriteLine(res);
            }
            catch (Exception e) when (e.InnerException != null)
            {
                WriteLine(e.Message);
                WriteLine(e.InnerException.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            ReadLine();
        }
    }
} 
#endif

#if false
namespace Practic_25._03
{
    class ExamNameof
    { 
        public string Name { get; set; }
        public ExamNameof(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ExamNameof ex = new ExamNameof(null);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

             ReadLine();
        }
    }
} 
#endif

// сборщик мусора. Fundamentals.
#if true
namespace Practic_25._03
{
    // вспомогательный класс для создания мусора
    class GarbageHelper
    {
        // метод для создания мусора
        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Person p = new Person();
            }
        }
        class Person
        {
            string _name;
            string _surname;
            byte _age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 0 уровень 256 Кбайт памяти
            // 1 уровень 2Мбайт
            // 2 уровень 10Мбайт
            //GC.Collect();

            WriteLine("Демонстрация сборщика мусора");
            WriteLine($"Максимальное поколение: {GC.MaxGeneration}");

            GarbageHelper helper = new GarbageHelper();

            WriteLine($"Поколение объекта: {GC.GetGeneration(helper)}");

            WriteLine($"Занято памяти (байты): {GC.GetTotalMemory(false)}");

            helper.MakeGarbage();
            WriteLine($"Занято памяти (байт): {GC.GetTotalMemory(false)}");

            GC.Collect(0);

            WriteLine($"Теперь сколько занято памяти после очистки: {GC.GetTotalMemory(false)}");

            WriteLine($"Поколения объекта: {GC.GetGeneration(helper)}");

            GC.Collect();

            WriteLine($"Занято памяти (байт): {GC.GetTotalMemory(false)}");

            WriteLine($"Поколение объекта: {GC.GetGeneration(helper)}");


            // БД.Имя (100000)
            // БД.Город (2000)
            // БД.Имят


            ReadLine();
        }
    }
} 
#endif