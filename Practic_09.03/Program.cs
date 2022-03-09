using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if false
namespace Practic_09._03
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
} 
#endif

#if true
namespace Practic_09._03
{
    // class НаследуемыйКласс: БазовыйКласс, Интерфейс1, интерфейс2 ... {}  - основной шаблон подключения наследования
    // public НаследуемыйКласс: base()  - vj;yj ,eltn bcgjkmpjdfnm rjycnhernjhs yfcktletvjuj rkfccf

    //public sealed class Tutor : Human { }
    //public class Curator : Tutor { }
    public abstract class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;
        //protected string gender;

        //public Human(string fName, string lName)
        //{
        //    _firstName = fName;
        //    _lastName = lName;
        //}
        public Human(string fName, string lName, DateTime date)
        {
            _firstName = fName;
            _lastName = lName;
            _birthDate = date;
        }
        public abstract void Think();
        //public virtual void Print()
        public override string ToString()
        {
            //WriteLine($"Фамилия: {_lastName}\nИмя: {_firstName}\n" +
            return($"Фамилия: {_lastName}\nИмя: {_firstName}\n" +
                $"Дата рождения: {_birthDate.ToShortDateString()}");
        }

    }

    abstract class Learner : Human
    {
        string _institution;

        public Learner(string fName, string lName, DateTime date, string institution)
            : base(fName, lName, date)
        {
            _institution = institution;
        }

        public abstract void Study();

        //public override void Print()
        public override string ToString()
        {
            //base.Print();
            return base.ToString() +
                $"учебное заведение: {_institution}";
            //WriteLine($"учебное заведение: {_institution}");
        }

    }

    class Student : Learner
    {
        string _groupName;

        public Student(string fName, string lName, DateTime date, string institution, string nameGroup)
            : base(fName, lName, date, institution)
        {
            _groupName = nameGroup;
        }
        public override void Think()
        {
            WriteLine("Я думаю как студент");
        }
        public override void Study()
        {
            WriteLine("Я изучаю предметы в институте");
        }
        //public override void Print()
        public override string ToString()
        {
            //base.Print();
            //WriteLine($"Учусь в {_groupName} группе");
            return base.ToString() +
                $"Учусь в {_groupName} группе";
        }

    }

    class SchoolChild : Learner
    {
        string _className;

        public SchoolChild(string fName, string lName, DateTime date, string institution, string nameClass)
            : base(fName, lName, date, institution)
        {
            _className = nameClass;
        }
        public override void Think()
        {
            WriteLine("Я думаю как школьник");
        }
        public override void Study()
        {
            WriteLine("Я изучаю предметы в школе");
        }
        //public override void Print()
        public override string ToString()
        {
            //base.Print();
            //WriteLine($"Учусь в {_className} классе");
            return base.ToString() +
                $"Учусь в {_className} классе";
        }

    }

#if false
    public class Employee : Human
    {
        double _salary;
        //new string gender;
        //public Employee(string fName, string lName) : base(fName, lName) { }
        public Employee(string fName, string lName, double salary) : base(fName, lName)
        {
            _salary = salary;
        }
        /*public Employee(string fName, string lName, double salary, DateTime date) : base(fName, lName, date)
        {
            _salary = salary;
        }*/

        //public new void Print()
        public override void Print()
        {
            //base.Show();
            Console.WriteLine($"ЗП: {_salary}");
        }
    }

    class Manager : Employee
    {
        string _fieldActivity;
        public Manager(string fName, string lName, double salary, DateTime date, string activity)
            : base(fName, lName, salary, date) { _fieldActivity = activity; }

        public void ShowManager()
        {
            WriteLine($"менеджер. Сфера деятельности: {_fieldActivity}");
        }
    }

    class Scientist : Employee
    {
        string _scientificDirection;

        public Scientist(string fName, string lName, double salary, DateTime date, string direction)
            : base(fName, lName, salary, date)
        {
            _scientificDirection = direction;
        }
        public void ShowScientist()
        {
            WriteLine($"Учёный. Научное направление: {_scientificDirection}");
        }
    }

    class Specialist : Employee
    {
        string _qualification;
        public Specialist(string fName, string lName, double salary, DateTime date, string qualification)
            : base(fName, lName, salary, date)
        {
            _qualification = qualification;
        }
        public void ShowSpecialist()
        {
            WriteLine($"Специалист. Квалификация: {_qualification}");
        }

    } 
#endif


    class Program
    {
        static void Main(string[] args)
        {
            //Employee manager = new Manager("Александр", "Дронов", 100000.254, new DateTime(1800, 12, 15), "отдел красок");
            //Human employee = new Employee("Александр", "Дронов", 100000.254,
            //    new DateTime(1800, 12, 15));
            //employee.Print();

            Student student = new Student("Иван", "Иванов",
                new DateTime(1999, 8, 28), "Институт", "группа1");

            //Learner[] learners =
            //{
            //    new Student("Иван", "Иванов",
            //    new DateTime(1999, 8, 28), "Институт", "группа1"),

            //    new SchoolChild("Пётр", "Петров",
            //    new DateTime(2010, 3, 20), "Школа", "Класс1")
            //};

            //foreach (Learner learner in learners)
            //{
            //    //learner.Print();
            //    WriteLine(learner);
            //    learner.Think();
            //    learner.Study();
            //}
            WriteLine();
            WriteLine();

            WriteLine($"Полное имя типа {student.GetType().FullName}");
            WriteLine($"Имя текущего элемента {student.GetType().Name}");
            WriteLine($"Базовый класс текущего элемента {student.GetType().BaseType}");

            /*
            Equals - виртуальный метод, сравнивает объекты
            Finalize - метод принудительно освобождает ресурсы 
            GetHashCode - виртуальный метод
            GetType
            ReferenceEquals
            ToString - виртуальный метод (строковое представление текущего объекта)
             */


#if false
            Employee[] employees = { manager, new Scientist("Иван", "Иванов", 1954.12,
                new DateTime(1956, 02, 14), "история"),
                new Specialist("Пётр", "Петров", 198474.02,
                new DateTime(1986, 06, 06), "грузчик") };

            foreach (Employee employee in employees)
            {
                employee.Print();
                // employee.ShowManager();
                // 1 способ вызова метода из дочерних классов
                try
                {
                    ((Specialist)employee).ShowSpecialist();
                }
                catch { }

                // 2 способ
                Scientist scientist = employee as Scientist;
                if (scientist != null)
                    scientist.ShowScientist();

                // 3 способ
                if (employee is Manager)
                    (employee as Manager).ShowManager();
#if false
                /*
                         try {

                        }
                        catch ()
                        {
                        }
                        finalize{ сработает в любом случае
                        }
                         */ 
#endif
            }

            //Employee employee1 = new Employee("Иван", "Иванов");
            //employee1.Print();

            //Employee employee2 = new Employee("Пётр", "Петров", 1544445.445, DateTime.Now);
            //employee2.Print();  
#endif

            Console.ReadLine();
        }
    }
} 
#endif