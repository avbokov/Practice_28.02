using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_23._03
{

    [Serializable]
    public class MyException : Exception
    {
        public DateTime TimeException { get; private set; }
        public MyException() : this("Моё исключение") { TimeException = DateTime.Now; }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    //public class MyException : ApplicationException

    //{
    //private string _message;
    //public DateTime TimeException { get; private set; }

    //public MyException(): base("Моё исключение") { TimeException = DateTime.Now; }


    //{
    //_message = "Моё исключение";
    //TimeException = DateTime.Now;
    //}
    //public override string Message
    //{
    //    get { return _message; }
    //}
    //}
    internal class Class2
    {
        // System.Exception; базовый класс, где есть все исключения

        /* свойства:
        string Message
        IDictionary Data
        string Source
        string StackTrace
        MethodBase TargetSite
        string HelpLink
        Exception InnerException
         */

        // наследуются 2 класса:
        // SystemException
        //        StackOverflowException - когда переполнение стэка
        //        ArgumentException

        // ApplicationException

        //try {
        //}catch (MyException e){
        //    Write(e.Message);
        //    }

        //try {
        //        // код, в котором может быть исключение
        //    }
        //catch (тип_исключения){
        //        // код, который обрабатывает исключения
        //    }
        //finally {
        //        // 
        //    }
        public void DividByZero()
        {

        try {
                int a = int.Parse(ReadLine());
                int b = int.Parse(ReadLine());
            WriteLine($"{a} / {b} - {a/b}");
            }
        catch (DivideByZeroException e){
               WriteLine(e.Message);
            }
        finally {
            WriteLine("Освобождение ресурсов");
            }
        }
    }
}
