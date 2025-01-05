namespace d22
{
    class program
    {
        public static void Main(String[] args)
        {
            {
                // this a way to implemenet obj from abstract class
                // vechle class is abstract and honda class called concrete
                Vechile v = new Honda("honda","civic",2021);

                IDerivable cat = new Caterpillar();
                cat.z();
                cachier cash = new cachier(new cash());
                cachier visa = new cachier(new Visa());

                cash.checkout(99.999m);
                visa.checkout(252.564m);

            }

        }
    }

    class cachier
    {
        IPayment payment;

        public cachier(IPayment payment)
        {
            this.payment = payment;
        }
        public void checkout(decimal amount)
        {
            payment.Pay(amount);
        }
    }
    interface IPayment
    {
        void Pay(decimal amount);
    }
    class cash :IPayment
    {
       public void Pay(decimal amount)
        {
            Console.WriteLine($"cash Payment : ${Math.Round(amount,2)}");
        }
    }class Debit : IPayment
    {
       public void Pay(decimal amount)
        {
            Console.WriteLine($"Debit Payment : ${Math.Round(amount,2)}");
        }
    }class Visa : IPayment
    {
       public void Pay(decimal amount)
        {
            Console.WriteLine($"Visa Payment : ${Math.Round(amount,2)}");
        }
    }
    abstract class Vechile
    {
        protected string brand, model;
        protected int year;
        protected Vechile(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }
    }

    interface IDerivable
    {
        void y();
        void z() 
        {
            Console.WriteLine("z");
           // return 12;
        }
        public int sum(int x, int y)
        {
            return x + y;
        }
    }

    class Honda : Vechile
    {
        public Honda(string brand, string model, int year) : base(brand, model, year)
        {
        }
    }
    class Caterpillar : IDerivable
    {
        public void y()
        {
            Console.WriteLine("y in caterpillar");
        }
       
        
    }
}
