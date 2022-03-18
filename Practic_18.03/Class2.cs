using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_18._03
{
    class DateComparer : IComparer <Student>
    {
        public int Compare(Student x, Student y)
        {           
            return DateTime.Compare(x.BirthDate, y.BirthDate);            
        }
    }
    class Student : IComparable <Student>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Фамилия: {Lastname}, Имя: {Firstname}, " +
                $"Дата: {BirthDate.ToLongDateString()}";
        }
        public int CompareTo(Student obj)
        {
            return Lastname.CompareTo(obj.Lastname);           
        }
    }
}
