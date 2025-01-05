using System.Collections;

namespace d26
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ref in comparison
            //var emp = new Employee("ahmed", "sw", 6000, 10);
            //var emp2 = new Employee("ahmed", "sw", 6000, 10);
            //var emp3 = emp2;

            //Console.WriteLine(emp == emp2); //check equalty in ref not in content ---> i edit this operater(==) in employee class to check in content
            //Console.WriteLine(emp2 == emp3);
            //Console.WriteLine(emp.Equals(emp2)); //check equalty in ref not in content 
            //Console.WriteLine(emp.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());
            //Console.WriteLine(emp3.GetHashCode()); 
            #endregion

            #region IEnumerable
            //fiveIntegers f = new fiveIntegers(1, 2, 3, 4, 5);
            //foreach (var item in f) // f 3shan class lazem ykon implement IEnumerable
            //{
            //    Console.Write(item);
            //} 
            #endregion

            #region Icomparable
            //var temps = new List<temp>();
            //Random r = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    temps.Add(new temp(r.Next(-30, 50)));
            //}
            //foreach (var item in temps)
            //{
            //    Console.WriteLine(item.x);
            //}
            //Console.WriteLine("After Sorting");
            //temps.Sort(); // this will call CompareTo method in temp class
            ////temps.Sort((x, y) => x.x.CompareTo(y.x)); //(easy way without implement an compareTo func) this will call CompareTo method in temp class
            //foreach (var item in temps)
            //{
            //    Console.WriteLine(item.x);
            //} 
            #endregion

        }

    }
    class temp : IComparable
    {
        public double x { get; }
        public temp(double x)
        {
            this.x = x;
        }

        public int CompareTo(object? obj)
        {
          if(obj is null)
                return 1;
            var t = obj as temp;
            if (t is null)
                throw new ArgumentException("Object is not temp");
            return x.CompareTo(t.x);
        }
    }

    public class fiveIntegers : IEnumerable     //this class to store 5 integers in array
    { 
        private int[] ints = new int[5];

        public fiveIntegers(int one,int two,int three ,int four,int five)
        {
            this.ints =new[]{one,two,three ,four,five};
        }

        //public IEnumerator GetEnumerator()
        //{
        //    foreach (var item in ints)
        //    {

        //        yield return item;
        //    }
        //}



        #region if you dont use yield key word you should make that
        public IEnumerator GetEnumerator() => new Enumerator(this);
        class Enumerator : IEnumerator
        {
            int currentIndex = -1;
            fiveIntegers f;
            public Enumerator(fiveIntegers f)
            {
                this.f = f;
            }
            public bool MoveNext()
            {
                if (currentIndex > f.ints.Length - 1)
                    return false;
                currentIndex++;
                return currentIndex < f.ints.Length;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public object Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new InvalidOperationException("Enumerator not started");
                    if (currentIndex == f.ints.Length)
                        throw new InvalidOperationException("Enumeration has Ended");
                    return f.ints[currentIndex];
                }
            }

        }

        #endregion

    }
}