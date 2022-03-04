using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_04._03
{
    //      Общий шаблон создания класса
    /*  [модификатор] class имя_класса
    {
        [модификатор] тип_данных имя_поля;
        [модификатор] тип_данных имя_метода([параметры])
        { 
        
        }
    }
    
    private - данные доступны внутри класса и во вложенных классах

    protected - данные доступны только методам внутри класса и вложенным классам или в его дочерних классах

    internal - данные доступны в методах текущей сборки(зн. по умолчанию)

    protected internal - данные доступны только методам вложенного или производного типа класса и любым методам текущей сборки

    public - все доступны во всех классах, методах и сборках

                    Объявление полей:

    static - используется для объявления статического поля ( принадлежит классу, а не объекту). Является общим для всех экземпляров класса.

    const - значение этого поля не может быть измененно и должно быть проинициализировано.

    readonly - поле будет использоваться только для чтения. Присвоение возможно либо через конструктор, либо сразу при объявлении.

    */

    /*struct Dimensions
    {
        private double Length;
        private double Width;

        public Dimensions(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void Print()
        {
        Console.WriteLine($"Длина {Length}, ширина {Width}");
        }
    }*/
    /*class Student
    {
        int _studentID;
        private string _firstName = "Иван";
        string _lastName = "Иванов";
        string _group;

        private void Print()
        {
            Console.WriteLine($"Студент {_firstName} {_lastName}");
        }
    }*/

    /*class Car
    {
        private string _driverName;
        private int _currSpeed;

        //public Car()
        public Car(string name, int speed)
        {
            //_driverName = "Спиди Гонщик";
            _driverName = name;
            //_currSpeed = speed;
            _currSpeed = 10;
        }

        public Car(): this("Без водителя", 0) { }
        public Car(string name): this(name, 0) { }

        // статический конструктор всегда только один, выполняется только один раз (независимо сколько объектов мы создали),
        //  имеет доступ только к статическим полям класса.

        public void SetDriver(string driverName)
        {
            this._driverName = driverName;
        }
        public void Print()
        {
            Console.WriteLine($"{_driverName} едет со скоростью {_currSpeed} км/ч.");
        }

        public void SpeedUp(int delta)
        {
            _currSpeed += delta;
        }

    }*/

    /*class Bank
    {
        private double _currBalance;
        private static double _bonus;

        public Bank(double balance)
        {
            this._currBalance = balance;
        }

        static Bank()
        {
            _bonus = 1.04;
        }

        public static void SetBonus(double newrate)
        {
            _bonus = newrate;
        }

        public static double GetBonus()
        {
            return _bonus;
        }

        public double GetPercent(double summa)
        {
            if ((_currBalance - summa) > 0)
            {
                double percent = summa * _bonus;
                _currBalance -= percent;
                return percent;
            }
            return -1;
        }

    }*/

    /*public class ClassA
    {
        public void MethodA(ClassB obj)
        {
            obj.MethodB(this);
        }
    }
    public class ClassB
    {
        public void MethodB(ClassA obj)
        {
            Console.WriteLine("Работа с классом " + obj.GetType().Name);
        }
    }*/
    
    class Program
    {
        /*private static int Mult(int min, int max)
        {
            int result = 1;
            for (int i = min; i <= max; i++)
                result *= i;

            return result;
        }*/



        //private static void MyFunction(out int i)
        //{
        //    i = new Random().Next(10);
        //}

        /*private static void MyFunction(ref int i,ref int[] myArr)
        {
            Console.WriteLine("Внутри функции MyFunction i = " + i);
            Console.Write("MyArr { ");
            foreach (int item in myArr)
                Console.Write(item + " ");
            Console.WriteLine("}");

            i = 100;
            myArr = new int[] {3,2,1 };

            Console.WriteLine("Внутри функции MyFunction после изменения i = " + i);
            Console.Write("MyArr { ");
            foreach (int item in myArr)
                Console.Write(item + " ");
            Console.WriteLine("}");
        }*/

        /*private static bool Fibanachi(int num)
        {
            bool flag = false;
            for (int i = 0, j = 1, k = 0; i <= num || j <= num; k++)
            {
                if (k % 2 == 0)
                {
                    if (i >= 1 && i <= num)
                        flag = true;
                    i += j;

                }
                else
                {
                    if (j >= 1 && j <= num)
                        flag = true;
                    j += i;
                }
            }
            if (flag)
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }*/
        public static void Arr(out int[]arr)
        {
            arr = new int[10];
            Console.WriteLine("массив arr { ");
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("}");
        }

        private static void Sorted(bool choice)
        {
            int[] myArray;
            Arr(out myArray);          

            if (choice) { }
            else { }


        }

        private static int BoubleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //double length = 7.34, width = 23.9;
            //Dimensions dimensions = new Dimensions(length, width);
            //dimensions.Print();

            //Student student = new Student();
            //student.Print();

            //Car car = new Car();
            ////Car car = new Car("Fast speedy", 15);
            //for (int i = 0; i < 10; i++)
            //{
            //    car.SpeedUp(5);
            //    car.Print();
            //}

            //Bank b1 = new Bank(1000000);
            //Console.WriteLine($"Текущий бонусный процент: {Bank.GetBonus()}");
            //Console.WriteLine("Ваш депозит на {0:C}, в кассе забрать: {1:C}", 10000, b1.GetPercent(10000));

            //ClassA a = new ClassA();
            //ClassB b = new ClassB();
            //a.MethodA(b);

            //int i = 10;
            //int[] myArr = { 1,2,3};

            //Console.WriteLine("Внутри функции Main i = " + i);
            //Console.Write("MyArr { ");
            //foreach (int item in myArr)
            //    Console.Write(item + " ");
            //Console.WriteLine("}");

            //MyFunction(ref i, ref myArr);
            //Console.WriteLine("Внутри функции Main после изменения i = " + i);
            //Console.Write("MyArr { ");
            //foreach (int item in myArr)
            //    Console.Write(item + " ");
            //Console.WriteLine("}");

            //int i;
            //MyFunction(out i);
            //Console.WriteLine("i= " + i);

            //Console.WriteLine(Mult(5,10));

            Console.WriteLine(Fibanachi(8));

            Console.ReadLine();
        }
    }
}
