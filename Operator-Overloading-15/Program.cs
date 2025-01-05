namespace day15
{
    class program
    {
        public static void Main(string[] args)
        {
            #region Obj Operator
            //money money1 = new money(7500);
            //money money2 = new money(5000);
            //money m3 = money2 + money1;
            //money m4 = money2 - money1;
            //Console.WriteLine(m3.amount);
            //Console.WriteLine(m4.amount);

            #endregion

            #region Destructor
            //Console.WriteLine($"befor: {GC.GetTotalMemory(false)}");
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //Console.WriteLine($"after: {GC.GetTotalMemory(true)}");

            #endregion
            st st = new st();
            Console.WriteLine(st.x);
        }
    }
   public struct st
    {
                          /// not support field iniatalizer ----> try in main not appear 5
       public int x = 5;
        public int y {  get; set; }
        public st(int X)
        {
            this.x = X;
        }
        public void tst(int X)
        {
            Console.WriteLine("test");
        }
         st()
        {
             this.x = 8;
        }
    }
         #region nested type
    class c
    {
        public a compositeType { get; set; }
        public c()
        {
            compositeType = new a()
            {
                id = -1,
                name = "NA"
            };
        }
    }
    public class a
    {
        public int id { get; set; }
        public string name { get; set; }

        class b
        {

        }
    } 
    #endregion
    class money
        {
            public decimal amount;
            public decimal Amount { get => amount; }
            public money(decimal amount)
            {
                this.amount = Math.Round(amount, 2);
            }
            ~money()
            {
                Console.WriteLine("your project is disposed");
            }

            public static money operator +(money m1, money m2)
            {
                return new money(m1.amount + m2.amount);
            }
            public static money operator -(money m1, money m2)
            {
                return new money(
                    Math.Abs(m1.amount - m2.amount));
            }
        }
}


