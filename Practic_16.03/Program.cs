using System;
using static System.Console;
using System.Collections.Generic;   // обобщённые коллекции
using System.Collections;   // обобщённые коллекции
//using System.Collections.Concurrent;    // коллекции поддерживают многопоточный доступ
//using System.Collections.Specialized;    // работа с коллекциями особым образом
//using System.Collections.ListDictionary;    // 
//using System.Collections.HybridDictionary;    // 
//using System.Collections.CollectionUtil;    // коллекции игнорируют регистр строк
//using System.Collections.NameValueCollection;    // 
//using System.Collections.StringCollection;    // 
//using System.Collections.StringDictionary;    // 

using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if false
namespace Practic_16._03
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

namespace Practic_16._03
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList2 = new ArrayList(7);
            ArrayList arrayList3 = new ArrayList(new int[] { 1, 2, 3 });
            /*
             Методы:
            
            Capacity
            TrimToSize
            Add(object)
            AddRange(ICollection)
             */

            ArrayList arrayList = new ArrayList();
            Console.WriteLine($"Вместимость по умолчанию: {arrayList.Capacity}");

            arrayList.Add("one");
            Console.WriteLine($"Вместимость после добавления одного объекта: " +
                $"{arrayList.Capacity}");

            arrayList.AddRange(new int[] { 1, 2, 3, 5, 6 });
            Console.WriteLine($"Вместимость после добавления коллекции: " +
                $"{arrayList.Capacity}");

            arrayList.Capacity = 10; // назначили вручную вместимость коллекции
            Console.WriteLine($"Вместимость заявлена явно: " +
                $"{arrayList.Capacity}");

            Console.WriteLine($"Фактическое количество элементов: {arrayList.Count}");

            arrayList.TrimToSize();
            Console.WriteLine($"Вместимость уменьшена до реального количества элементов: " +
                $"{arrayList.Capacity}");

            Console.WriteLine($"Элементо под индексом 3: {arrayList[3]}");

            foreach (object obj in arrayList) // object obj потому что разные типы данных в коллекции
                Console.WriteLine(obj);

            Console.ReadKey();
        }
    }
}

#endif

#if false
namespace Practic_16._03
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList2 = new ArrayList(7);
            /*
            Insert(int, object)
            Insert(int, ICollection)
            RemoveAt(int) RemoveRange(int, int)
            GetRange(int, int)
            IndexOf/LastIndexOf(object)
            Sort()  только если данные одного типа
             */

            ArrayList arrayList3 = new ArrayList(new int[] {1,2,3,4});

            WriteLine("Вставка элемента");
            arrayList3.Insert(2, "hello");
            foreach (object obj in arrayList3)
                WriteLine(obj);

            WriteLine("Удаление элемента");
            arrayList3.RemoveAt(3);
            foreach (object obj in arrayList3)
                WriteLine(obj);

            WriteLine($"Поиск индекса элемента Hello: {arrayList3.IndexOf("hello")}");

            ArrayList list = new ArrayList(new string[] 
            {
                "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
            });

            ArrayList list2 = new ArrayList(list.GetRange(1,5));

            foreach (string str in list2)
                WriteLine(str);

            WriteLine("Сортировка коллекции");
            list.Sort();
            foreach (string obj in list)
                WriteLine(obj);


            ReadKey();
        }
    }
} 
#endif

#if false
namespace Practic_16._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack2 = new Stack(new ArrayList { 1, 5, 8 });
            /*
            Методы: 
             
            Push
            Pop
            Peek
            CopyTo(Array, int)
            Contains возвращает true или false
            Clear
             */

            Stack stack = new Stack();  // нельзя обратиться по индексу элемента

            Write("Метод Push(): ");
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");

            foreach (string s in stack)
                Write(s);

            WriteLine("Метод Pop(): ");
            stack.Pop();
            foreach (string s in stack)
                Write(s);

            WriteLine($"Метод Peek(): {stack.Peek()}");
            WriteLine($"Существует ли элемент ten: {stack.Contains("ten")}");
            WriteLine($"Существует ли элемент one: {stack.Contains("one")}");

            WriteLine("Метод CopyTo(): ");
            string[] arr = new string[stack.Count];
            stack.CopyTo(arr, 0);
            foreach (string s in arr)
                Write(s);

            stack.Clear();
            WriteLine($"Количество элементов после вызова Clear(): {stack.Count}");


            ReadKey();
        }
    }
} 
#endif

#if false
namespace Practic_16._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(7, 3.0f);  // нельзя обратиться по индексу элемента
            //  3.0f увеличение коллекции в 3 раза
            /*
            Enqueue/Dequeue(object)
            Peek возвращает без удаления из коллекции
             */
            WriteLine("Метод Enqueue");
            for (int i = 0; i < 4; i++)
            {
                queue.Enqueue(i);
            }

            foreach (int i in queue)
                WriteLine(i);

            WriteLine($"Метод Dequeue: {queue.Dequeue()}");
            WriteLine($"Существование элемента 0: {queue.Contains(0)}");
            WriteLine($"Метод Peek: {queue.Peek()}");           
            WriteLine($"Существование элемента 2: {queue.Contains(2)}");

            ReadKey();

        }
    }
} 
#endif

#if false
namespace Practic_16._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(); // поиск информации происходит быстро, часто используется

            /*
            Методы:

            Add(object, objet)
            Remove(object)
            Keys, Values
            ContainsKey, ContainsValue
             */

            ht.Add(1, "One");
            ht.Add("two", "Иван");

            foreach (object o in ht.Keys)
                WriteLine($"Ключ {o}. Значение {ht[o]}");

            ht.Add("three", 5.487);

            foreach (object o in ht.Values)
                WriteLine($"Значение {o}");

            ht.Remove("two");

            WriteLine($"Существует ли элемент two: {ht.ContainsKey("two")}");

            ReadKey();
        }
    }
} 
#endif

#if false
namespace Practic_16._03
{
    class Program
    {
        class Student
        { 
            public string Name { get; set; }
            public override string ToString()
            {
                return $"Name: {Name}";
            }
        }
        static void Main(string[] args)
        {
            SortedList sortedlist = new SortedList();   // автоматом сортирует по ключу
            sortedlist.Add(3, 6.7);
            sortedlist.Add(2, new Student { Name = "Ivan"});
            sortedlist.Add(1, "one");

            foreach (object o in sortedlist.Keys) // вывод будем производить по ключу
                WriteLine($"Ключ: {o} Значение: {sortedlist[o]}");

            for (int i = 0; i < sortedlist.Count; i++)
            {
                WriteLine($"ключ: {sortedlist.GetKey(i)}\n" +
                    $"значение: {sortedlist.GetByIndex(i)}");
            }

            foreach (object o in sortedlist.Values)
            {
                WriteLine(o);
            }

            sortedlist.Remove(3);
            WriteLine($"Существует ли элемент 3: {sortedlist.ContainsKey(3)}");


            ReadKey();
        }
    }
}
#endif

#if false
namespace Practic_16._03
{
    class SortedArrayList : ArrayList
    {
        public void AddSorted (object item)
        {
            int position = BinarySearch(item);

            if (position < 0) 
            position = ~position;

            Insert(position, item);
        }
        public void ModifySorted(object item, int index)
        {
            RemoveAt(index);
            int position = BinarySearch(item);

            if (position < 0) 
            position = ~position;

            Insert(position, item);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ICollections
            Ilist
            IDictionary
            IDictionaryEnumerator
            */
            SortedArrayList sortedArray = new SortedArrayList();

            WriteLine("Начальные значения");
            sortedArray.AddSorted(200);
            sortedArray.AddSorted(-7);
            sortedArray.AddSorted(0);
            sortedArray.AddSorted(-20);
            sortedArray.AddSorted(56);
            sortedArray.AddSorted(500);
            sortedArray.AddSorted(200);

            foreach (int i in sortedArray)
                Write(i + " ");
            WriteLine();

            WriteLine("Изменение значения");
            sortedArray.ModifySorted(3,5);
            sortedArray.ModifySorted(-1,2);
            sortedArray.ModifySorted(2,3);
            sortedArray.ModifySorted(7,3);

            foreach (int i in sortedArray)
                Write(i + " ");
            WriteLine();

            ReadKey();
        }
    }
} 
#endif

#if true
namespace Practic_16._03
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
    class Program
    {
        static Hashtable group = new Hashtable
        {
            { new Student { FirstName = "Иван", LastName = "Иванов"},
              new ArrayList{3,5,2} },
            { new Student { FirstName = "Пётр", LastName = "Петров"},
              new ArrayList{4,4,5} }
        };
        static void RaitingList()
        {
            WriteLine("Список студентов с оценками");
            foreach (Student student in group.Keys)
            { 
                Write($"{student}: ");
                foreach (int i in (group[student] as ArrayList))
                {
                    Write(i);
                }
                WriteLine();
            }
        }
        static void SetRaiting(string name, int mark)
        {
            WriteLine($"Студент {name} получил оценку {mark}");
            foreach (Student student in group.Keys)
            {
                if (student.FirstName == name)
                    (group[student] as ArrayList).Add(mark);
            }

        }
        static void Main(string[] args)
        {
            RaitingList();
            SetRaiting("Пётр", 1);
            RaitingList();

            ReadKey();
        }
    }
} 
#endif