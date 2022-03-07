using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Practic_07._03
//{
//    partial class MyClass
//    {
//        //public static void Method2()
//        //{
//        //    Console.WriteLine("Класс: MyClass, метод: Method2");
//        //}
//    }
//}

namespace A
{
    class ClassB
    {
        public void Print()
        {
            Console.WriteLine("Printing from A.ClassB");
        }
    }
}
namespace A
{
    class ClassC
    {
        public void Print()
        {
            Console.WriteLine("Printing from A.ClassC");
        }
    }
}