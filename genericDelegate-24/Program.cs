namespace d24
{
    class program
    {
       public delegate bool mydelegate(int i); // da delegate 3ade

         static void Main(string[] args)
        {
            #region Delegate
            IEnumerable<int> ints = new List<int>() { 2, 5, 4, 9, 5, 8, 6, 8, 9, 1, 3, 2 };

            //printNumber(ints, n => n < 8);
            //printNumber(ints, n => n > 8);
            //printNumber(ints, n => n % 2 == 0);

            #endregion

            #region Generic Delegate
            //Action<string > action = print;
            //action("Ahmed");
            //Func<int ,int ,int> func = sum;
            //Console.WriteLine(func(5, 6));
            //Predicate<int> predicate = isEven;
            //Console.WriteLine(predicate(58));
             printNumber(ints, n => n < 6, () => Console.WriteLine("number is less than 6"));
            #endregion

        }
        static void print(string name) => Console.WriteLine(name);
        static int sum(int x1,int x2) => x1 + x2;
        static bool isEven(int x) => x % 2 == 0;

        public static void printNumber<T>(IEnumerable<T> ints, Func<T,bool>filter,Action action)
        {
            action();
            foreach (var i in ints)
            { 
            if (filter(i))
            {
                    Console.Write(i);
                }
        }
        }

    }
}