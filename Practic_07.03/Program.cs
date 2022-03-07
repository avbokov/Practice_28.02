#if false
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_07._03
{
    //class Example
    ////class Student
    //{
    //    // public int MyProperty { get; set; } // нельзя использовать без get, без set - можно
    //    //public string FirstName { get; set; } = "Алескандр";
    //    //public string LastName { get; set; } = "Дронов";
    //    //public DateTime DataBirth { get; set; } 
    //    //public string Group { get; set; }

    //    //public string Print()
    //    //{
    //    //    return $"Имя: {FirstName} Фамилия: {LastName} " +
    //    //        $"Дата рождения: {DataBirth.ToLongDateString()} Номер группы: {Group}";
    //    //}

    //    //propfull + 2 раза Tab
    //    //prop + 2 раза Tab
    //    //propg + 2 раза Tab

    //    //string _firstName;
    //    //public string FirstName
    //    //{
    //    //    get { return _firstName != null ? _firstName : "Не задано"; }
    //    //    set { _firstName = value.ToUpper(); }
    //    //}

    //    //string _lastName;
    //    //public string LastName
    //    //{
    //    //    get { return _lastName != null ? _lastName : "Не задано"; }
    //    //    set { _lastName = value.ToUpper(); }
    //    //}

    //    //int _age;
    //    //public int Age
    //    //{
    //    //    get { return _age; }
    //    //    set { _age = (value > 100 || value < 1) ? 0 : value; }
    //    //}

    //    //int _wage;
    //    //public int Wage
    //    //{
    //    //    get { return _wage; }
    //    //    set { _wage = value < 0 ? 0 : value; }
    //    //}

    //    //public string Print()
    //    //{
    //    //    return $"Имя: {FirstName}\n" +
    //    //        $"Фамилия: {LastName}\n" +
    //    //        $"Возраст: {Age}\n" +
    //    //        $"Зарплата: {Wage}\n";
    //    //}



    //    //static int _num;
    //    ////public int Num
    //    //public static int Num
    //    //{
    //    //    get { return _num; }
    //    //    set { _num = value; }
    //    //}

    //    //public void Set(int num)
    //    //{
    //    //    _num = num;           
    //    //}
    //    //public int Get()
    //    //{
    //    //    return _num;
    //    //}
    //}
    class Program
    {
        // Пример 1
        //private static int Sum(int[] arr)
        //private static int Sum(params int[] arr)
        //{
        //    int res = 0;
        //    foreach (int i in arr)
        //        res += i;
        //    return res;
        //}
        static void Main(string[] args)
        {
            // Пример 1
            ////Console.WriteLine(Sum(new int[] { 1, 2, 3, 4 }));
            //Console.WriteLine(Sum(1, 2, 3, 4 ));

            // Пример 2 (методы раскиданы по разным файлам)
            //MyClass.Method1();
            //MyClass.Method2();

            //Example example = new Example();
            //// new имя-класса[(вызов любого конструктора)]{Имя_свойства = значение, }
            //Console.WriteLine("Введите число: ");
            ////example.Set(int.Parse(Console.ReadLine()));
            //example.Num(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Вы ввели: ");
            //Console.WriteLine(example.Num());

            //Example example = new Example
            //{
            //    FirstName = "Александр",
            //    LastName = "Дронов",
            //    Age = 92,
            //    Wage = 5000
            //};
            //Example example1 = new Example();
            //example1.FirstName = "Андрей";
            //example1.Age = 500;
            //example1.Wage = -10;
            //Console.WriteLine(example.Print());
            //Console.WriteLine(example1.Print());

            //Student student = new Student();
            //Student student2 = new Student
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    DataBirth = new DateTime(1900, 12, 11),
            //    Group = "25TR45"
            //};
            //Console.WriteLine(student.Print());
            //Console.WriteLine(student2.Print());

            //Console.WriteLine("Экземпляр класса Student не создан");
            //Student student1 = null;
            //DateTime? date = student1?.DataBirth;
            //Console.WriteLine($"Дата рождения: {date}");
            //Console.WriteLine("Group не указана");

            //Student student2 = new Student();
            //string groupName = student2?.Group;
            //Console.WriteLine($"Название группы: {groupName}");

            //Student[] students = { student1, student2 };
            //Student student = students?[0] ?? new Student {};
            //Console.WriteLine(student.Print());

            Console.ReadLine();
        }
    }
} 
#endif


#if false
namespace Practic07._03
{
    namespace A
    {
        class Incr
        {
            private int _count;
            public Incr(int count)
            {
                _count = count;
            }
            public int MultyIncr()
            {
                for (int i = 0; i < 5; i++)
                    _count++;
                return _count;
            }
        }
    }
    namespace B
    {
        class Incr
        {
            private int _var;
            public Incr(int var)
            {
                _var = var;
            }
            public int AnotherMultyIncr()
            {
                for (int i = 0; i < 5; i++)
                    _var += 10;
                return _var;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B.Incr incr = new B.Incr(10);
            Console.WriteLine(incr.AnotherMultyIncr()); A.Incr incr2 = new A.Incr(5);
            Console.WriteLine(incr2.MultyIncr());
            Console.ReadLine();
        }
    }
} 
#endif

#if false // разделение пространства имён по файлам и использование
using System;

using x = A;
//using A;
namespace Practic07._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClassA a = new ClassA();
            x::ClassA a = new x::ClassA();
            a.Print();

            //ClassB b = new ClassB();
            x::ClassB b = new x::ClassB();
            b.Print();

            //ClassC c = new ClassC();
            x::ClassC c = new x::ClassC();
            c.Print();

            Console.ReadLine();
        }
    }
} 
#endif

/*
 Создайте класс «Город». Необходимо хранить в полях
класса: название города, название страны, количество
жителей в городе, телефонный код города, название районов города.
Реализуйте методы класса для ввода данных,
вывода данных, реализуйте доступ к отдельным полям
через методы класса.
 */

using System;
using static System.Console;

namespace Practic_07._03
{
    class City
    {
        public string NameCity { get; set; } = "Нет данных";
        public string NameCountry { get; set; } = "Нет данных";
        public int CountPeople { get; set; } = 0;
        public int CodePhone { get; set; } = 0;
        public string[] NameDistr { get; set; } = new string[] {"Нет значений"};

        public void Print()
        { 
            Write($"{NameCountry}, {NameCity}, " + 
                $"{CountPeople}, " +
                $"{CodePhone}," +
                $" ");
            foreach (var i in NameDistr)
                Write(i+" ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City
            {
                NameCity = "Moscow",
                NameCountry = "Russia",
                CountPeople = 100000000,
                CodePhone = 495,
                NameDistr = new string[] { "Бутово", "Сколково", "ВДНХ" }
            };

            city.Print();

            City city2 = new City();
            city2.NameCity = "Arkhangelsk";
            //string nameCountry = city2?.NameCountry;    // проверка от нулевых значений, но лучше в конструкторе
            city2.CodePhone = 8182;
            city2.CountPeople = 500000;

            city2.Print();

            ReadLine();
        }
    }
}
