using System.Runtime.InteropServices;

namespace d23
{
    class program
    {
        public static void Main(String[] args)
        {
            {
                #region base class obj
                //Console.WriteLine("use base class obj");
                //print(12);
                //print("ahmed");
                //print(new{first = "sa", Last = "sa"}); // this called anonymas obj 
                #endregion

                #region Generic Method
                //Console.WriteLine("use Generic Method");
                //Print<int>(150);
                //Print("mo");
                //Print(new { first = "sa", Last = "sa" }); // this called anonymas obj 
                #endregion


                #region Generic class (VIP)
                //var typepar = new typeparameter<int>();
                //typepar.addd(1);
                //typepar.addd(2);
                //typepar.addd(3);
                //typepar.display(); 
                var person = new typeparameter<person>();
                person.addd(new person { first = "ahmed", last = "saad" });
                person.display(); // use tostring for class 
                #endregion
            }
        }
        public static void print(dynamic s) // this base class with object or dynamic keyword
        {                                   // دا حل مشكله تكرار الفانكشن---> بس دا مش افضل حل 
            Console.WriteLine($"{s}");
        }

        static void Print<T>(T val)        //Generic Method :
                                           //this solve problem of ---> performance, type safety,and efficiency 
        {
            Console.WriteLine($"{typeof(T)}");
            Console.WriteLine($"{val}");
        }
        // public void print(int s)
        //{
        //    Console.WriteLine("aaaaaaa");
        //} public void print(double s)
        //{
        //    Console.WriteLine("aaaaaaa");
        //}

        public class person
        {
            public string first { get; set; }
            public string last { get; set; }

            public override string ToString()
            {
                return $"{first} {last}";
            }
        }
            class typeparameter <T>
        {
            T[] items;

            public void addd(T Item)
            {
                if (items is null) 
                {
                    items = new T[] { Item };
                }
                else
                {
                    int length = items.Length;
                    var newarr = new T[length+1];
                    for (int i = 0; i < length; i++) 
                    {
                      newarr[i] = items[i]; 

                    }
                    newarr[newarr.Length-1]= Item;
                    items = newarr;
                }

            }
            public void removed(int pos)
            {
                if (pos == null || pos > items.Length)
                    return;
                int index =0;
                var arr = new T[items.Length-1];
                for (int i = 0; i < items.Length; i++) 
                {
                    if (pos == i)
                        continue;
                    arr[index++] = items[i];
                }
                items = arr;
            }

            public void display()
            {
                Console.Write("[");
                for (int i = 0; i < items.Length; i++)
                {
                    Console.Write(items[i]);
                    if (i < items.Length - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine("]");
            } 
            public bool IsEmpty => items is null || items.Length == 0;
            public int count => items.Length == 0 ? 0 : items.Length; 
        }
    }
}