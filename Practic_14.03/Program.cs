using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if false
namespace Practic_14._03
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
} 
#endif

// разбор ДЗ (1/5).

#if false
namespace Practic_14._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            //  22.12.2021
            //  22-12-2021
            //  22/12/2021
            //  2021.12.22

            //  1 способ
            //string[] arrDate = date.Split('.');
            //foreach (string s in arrDate)
            //    Console.WriteLine(s);
            //DateTime dt = new DateTime(Int32.Parse(arrDate[0]),
            //    Int32.Parse(arrDate[1]), Int32.Parse(arrDate[2]));
            //Console.WriteLine(dt.ToString());

            //  2 способ

            int season = Int32.Parse(Convert.ToDateTime(date).Month.ToString());

            if (season == 12 || season == 1 || season == 2)
                Console.Write("Зима ");
            else if (season >= 3 && season <= 2)
                Console.Write("Весна ");
            //  проверка по остальным месяцам

            string week = Convert.ToDateTime(date).DayOfWeek.ToString();

            Console.Write(week);

            Console.ReadLine();


        }
    }
} 
#endif

#if false
namespace Practic_14._03
{
    public class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }
    }

    public class Shop
    {
        Laptop[] laptopArr;
        public int Length
        {
            get { return laptopArr.Length; }
        }
        public Shop(int size)
        {
            laptopArr = new Laptop[size];
        }
        public Laptop this [int index]  // добавляем индексатор
        {
            get 
            {
                if (index >= 0 && index < laptopArr.Length)
                    return laptopArr[index];

                throw new IndexOutOfRangeException();
            }
            set 
            {
                laptopArr[index] = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // тип_данных this[тип_аргумента]{ get; set; }

            Shop laptops = new Shop(3);
            laptops[0] = new Laptop { Vendor = "HP", Price = 67520};
            laptops[1] = new Laptop { Vendor = "Lenovo", Price = 45000};
            laptops[2] = new Laptop { Vendor = "MacBook", Price = 243000};

            try
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    Console.WriteLine(laptops[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadLine();
        }
    }
} 
#endif

#if false
namespace Practic_14._03
{
    public class MultArray
    {
        private int[,] array;
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public MultArray(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }    
            set { array[r, c] = value; }    
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MultArray mult = new MultArray(2, 3);

            for (int i = 0; i < mult.Rows; i++)
            { 
                for (int j = 0; j < mult.Cols; j++)
                {
                    mult[i, j] = i + j;
                    Console.Write(mult[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
} 
#endif

#if false
namespace Practic_14._03
{
    public class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }
    }

    enum Vendors { HP, LENOVO, MACBOOK};
    public class Shop
    {
        Laptop[] laptopArr;
        public int Length
        {
            get { return laptopArr.Length; }
        }
        public Shop(int size)
        {
            laptopArr = new Laptop[size];
        }
        public Laptop this[int index]  // добавляем индексатор
        {
            get
            {
                if (index >= 0 && index < laptopArr.Length)
                    return laptopArr[index];

                throw new IndexOutOfRangeException();
            }
            set
            {
                laptopArr[index] = value;
            }
        }
        public Laptop this[double price]
        {
            get
            {
                if (FindByPrice(price) >= 0)
                    return this[FindByPrice(price)];
            throw new Exception("Error");
            }

            set
            {
                if (FindByPrice(price) >= 0)
                    this[FindByPrice(price)] = value;
            }
        }
        public int FindByPrice(double price)
        {
            for (int i = 0; i < laptopArr.Length; i++)
            {
                if (laptopArr[i].Price == price)
                    return i;
            }
            return -1;
        }

        public Laptop this[string name]
        {
            get
            {
                if (Enum.IsDefined(typeof(Vendors), name))
                {
                    return laptopArr[(int)Enum.Parse(typeof(Vendors), name)];
                }
                else
                    return new Laptop();
            }
            set
            {
                if (Enum.IsDefined(typeof(Vendors), name))
                {
                    laptopArr[(int)Enum.Parse(typeof(Vendors), name)] = value;
                }                
            }

        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // тип_данных this[тип_аргумента]{ get; set; }

            Shop laptops = new Shop(3);
            laptops[0] = new Laptop { Vendor = "HP", Price = 67520};
            laptops[1] = new Laptop { Vendor = "Lenovo", Price = 45000};
            laptops[2] = new Laptop { Vendor = "MacBook", Price = 243000};

            try
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    Console.WriteLine(laptops[i]);
                }
                Console.WriteLine();

                Console.WriteLine($"Производитель Lenovo: {laptops["LENOVO"]}");
                Console.WriteLine($"Стоимость в 243 000: {laptops[243000.0]}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadLine();
        }
    }
} 
#endif

//  Интерфейсы
#if false

namespace Practic_14._03
{
    //  синтаксис обозначения интерфейса
    //public interface INameInter
    //{
    //  void Method1();
    //  void Method2();
    //}

    public interface IWorker    // все интерфейсы публичные
    {
        //event EventHandler WorkEnded;   // событие, оповещает о завершении работы какого-либо сотрудника
        bool IsWorking { get; }
        string Work();
    }

    interface IManager
    {     
        List<IWorker> ListOfWorkers { get; set; }
        void Organize();
        void MakeBudget();
        void Control();
    }
    
    abstract class Human
    { 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public override string ToString()
        {
            return $"Фамилия: {Lastname} Имя: {Firstname}\n" +
                $"Дата рождения: {Birthdate.ToLongDateString()}";
        }
    }

    abstract class Employee : Human 
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\nДолжность: {Position} Зарплата: {Salary} руб.";
        }
    }

    class Director : Employee, IManager // именно в таком порядке, наследование только от одного класса, интерфейсов сколько угодно
    { 
        public List<IWorker> ListOfWorkers { get; set; }
        public void Control() {
            WriteLine("Контролирует процесс!");
        }
        public void MakeBudget()
        {
            WriteLine("Формирует бюджет");
        }
        public void Organize()
        {
            WriteLine("Организует работу");
        }
    }
    class Seller : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking { get { return isWorking; } }
        public string Work()
        {
            return "Продаёт товар";
        }
    }
    class Cashier : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking { get { return isWorking; } }
        public string Work()
        {
            return "Пробивает товар на кассе";
        }
    }
    class Storekeeper: Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking { get { return isWorking; } }
        public string Work()
        {
            return "Грузит товар";
        }
    }
    interface IPerson
    { 
        string Name { get; set; }
        string Email { get; }
        string LastName { set; }
    }

    interface IEployee: IPerson
    {
        int Salary { get; set; }
    }
    class Person : IEmployee
    {
        public int Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email => throw new NotImplementedException();
        public string LastName { set => throw new NotImplementedException(); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director
            {
                Lastname = "Директоров",
                Firstname = "Крутой",
                Birthdate = new DateTime(1988, 10, 12),
                Position = "Директор",
                Salary = 400000
            };

            IWorker seller = new Seller
            {
                Lastname = "Продавцов",
                Firstname = "Наглый",
                Birthdate = new DateTime(1995, 03, 25),
                Position = "Продавец",
                Salary = 15000
            };

            if (seller is Employee)
                WriteLine($"Заработная плата продавца: {(seller as Employee).Salary}");

            director.ListOfWorkers = new List<IWorker>
            {
                seller,
                new Cashier
                {
                    Lastname = "Кассиров",
                    Firstname = "Кас",
                    Birthdate = new DateTime(2000, 07, 07),
                    Position = "Кассир",
                    Salary = 18000
                },
                new Storekeeper
                {
                    Lastname = "Грузчиков",
                    Firstname = "Хилый",
                    Birthdate = new DateTime(1968, 11, 01),
                    Position = "Грузчик",
                    Salary = 30000
                }
            };

            WriteLine(director);

            if (director is IManager)
                director.Control();

            foreach (IWorker i in director.ListOfWorkers) 
            {
                WriteLine(i);
                if (i.IsWorking)
                    WriteLine(i.Work());
            }

            ReadKey();
        }
    }
} 
#endif

#if true
namespace Practic_14._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            WriteLine("Список студентов\n");
            foreach (Student student in auditory)
            {
                WriteLine(student);
            }
        }
    }
} 
#endif