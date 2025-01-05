using System.Threading.Channels;

namespace d20
{
    class program
    {

        public static void Main(String[] args)
        {
            //   // animal a = new animal();

            //   // eagle e1 = a as eagle;
            //    // Console.WriteLine(a);
               eagle eagle = new eagle();
              eagle.x = 5;
              lion lion = new lion(8);
              Console.WriteLine(eagle.x);
              Console.WriteLine(lion.x);
            //    Console.ReadKey();

            manager man = new manager(1000, "Boda", 10, 88, 176, "Manager");
            
            Console.WriteLine(man.ToString());
        }
    }

    abstract class animal : Object // object mwgod by defult msh m7tag 2defo
    {
        int X;
        protected animal()
        {
            this.X= x ;
        }
        public int x;
        abstract public void ani();
        public virtual void addtion()
        {
            Console.WriteLine("you inherit from animal");
        }

    }
    sealed class lion : animal
    {
        public lion(int X):base()
        {
            base.x = X;   
        }
        public override void ani()
        {
            Console.WriteLine("the Lion"); 
        }
        public sealed override void addtion() // sealed kda msh httwrth tanty
        {
            base.addtion();
            Console.WriteLine("LION");
        }
    }

    sealed class eagle : animal
    {
        int X;
        public eagle() : base()
        {
            base.x = X;
        }
        public  void eag()
        {
            Console.WriteLine("Eagle from Animal");
        }
        
        public override void ani()
        {
            Console.WriteLine("virtual func it work (:");
        }
    }
}