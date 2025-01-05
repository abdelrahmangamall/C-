using System.Diagnostics;

namespace d37
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region SingleThread
            //    //Console.WriteLine($"ProccesID: {Process.GetCurrentProcess().Id}");
            //    //Console.WriteLine($"ProcessorID: {Thread.GetCurrentProcessorId()}");
            //    //Console.WriteLine($"ThreadID: {Thread.CurrentThread.ManagedThreadId}");

            //    var walet = new Walet("BODA", 250);
            //    walet.RandomTransaction();
            //    Console.WriteLine("--------");
            //    Console.WriteLine($"{walet}");
            //    walet.RandomTransaction();
            //    Console.WriteLine("--------");
            //    Console.WriteLine($"{walet}"); 
            #endregion
            #region MultiThread
            //Thread.CurrentThread.Name = "Main Thread";
            //Console.WriteLine(Thread.CurrentThread.Name);
            //Console.WriteLine($"BackGroundThread :{Thread.CurrentThread.IsBackground}");
            //var walet = new WaletM("TEFA", 2500);
            //Thread th1 = new Thread(walet.RandomTransaction);
            //th1.Name = "TH1";
            //Console.WriteLine($"BackGroundThread th1 :{th1.IsBackground}");
            //Console.WriteLine($"after declarition : {th1.Name}{th1.ThreadState}");
            //Console.WriteLine($"after Start : {th1.Name}{th1.ThreadState}");
            //th1.Start();
            //th1.Join();

            //Thread th2 = new Thread(walet.RandomTransaction);
            //th2.Name = "TH1";
            //Console.WriteLine($"BackGroundThread th1 :{th2.IsBackground}");
            //Console.WriteLine($"after declarition : {th2.Name}{th2.ThreadState}");
            //th2.Start();
            //Console.WriteLine($"after Start : {th2.Name}{th2.ThreadState}");
            #endregion
            #region RaceCondition
            //  var walet = new WaletForRaceCondition("MO",50);
            // // walet.Debit(40);
            // //walet.Debit(30);
            //  // paralell with multi Threads
            //  var t1 = new Thread(() => walet.Debit(40));
            //  var t2 = new Thread(() => walet.Debit(30));
            //  t1.Start();
            //  t2.Start();
            //t1.Join();
            //t2.Join();
            //  Console.WriteLine(walet);
            #endregion

            #region DeadLock

            var w1 = new WaletForRaceCondition("Mo",200);
            var w2 = new WaletForRaceCondition("so",500);
            Console.WriteLine("\nBefore Transaction");
            Console.WriteLine("---------------------");
            Console.WriteLine($"{w1},\t {w2}");

            Console.WriteLine("\nAfter Transaction");
            Console.WriteLine("---------------------");
            var tmW2 = new TransferManager(w2,w1,250);
            var tmW1 = new TransferManager(w1,w2,52);
            var t1 = new Thread(tmW1.Transfer);
            t1.Name = "T1";
            var t2= new Thread(tmW2.Transfer);
            t1.Name = "T2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine($"{w1},\t {w2}");

            #endregion

        }
    }

    class TransferManager
    {
        private  WaletForRaceCondition from;
        private WaletForRaceCondition to;
        private int amountTransfer;
        public TransferManager(WaletForRaceCondition from, WaletForRaceCondition to, int amountTransfer)
        {
            this.from = from;
            this.to = to;
            this.amountTransfer = amountTransfer;
        }
        public void Transfer()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}trying to lock...{from}");
            lock (from)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}trying to lock...{from}");
                Thread.Sleep( 500 );
                Console.WriteLine($"{Thread.CurrentThread.Name}trying to lock...{to}");


                lock (to)
                {
                    from.Debit(amountTransfer);
                    to.Credit(amountTransfer);

                }
            }
        }

    }

 class WaletForRaceCondition
 {
        private readonly object bitcoinsLock = new object() ;
        public string Name { get; private set; }
        public int Bitcoins { get; private set; }

        public WaletForRaceCondition(string name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

        public void Debit(int amount)
        {
            lock (bitcoinsLock) 
            {
                if (Bitcoins >= amount)
                {
                    Thread.Sleep(500);
                    Bitcoins -= amount;
                }
            }
            
          
        }
        public void Credit(int amount)
        {
            Thread.Sleep(500);
            Bitcoins += amount;
            
        }
        public override string ToString()
        {
            return $"Name {Name}, Bitcions {Bitcoins}";
        }
    }


  class WaletM
    {
        public string Name { get; private set; }
        public int Bitcoins { get; private set; }

        public WaletM(string name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

        public void Debit(int amount)
        {
            Thread.Sleep(500);
            Bitcoins -= amount;
            Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId}\t"+
                    $"ProcessorID:{Thread.GetCurrentProcessorId()}\t -{amount}");
        }
        public void Credit(int amount)
        {
            Thread.Sleep(500);
            Bitcoins += amount;
            Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId}\t" +
                    $"ProcessorID:{Thread.GetCurrentProcessorId()}\t +{amount}");
        }

        public void RandomTransaction()
        {
            int[] amounts = { 10, 20, -15, 50, -10, 60, -80 };
            foreach (var item in amounts)
            {
                var absVal = Math.Abs(item);
                if (item >= 0)
                {
                    Credit(absVal);
                }
                else
                    Debit(absVal);
            }
        }

        public override string ToString()
        {
            return $"Name {Name}, Bitcions {Bitcoins}";
        }
    }
 class WaletS
    {
        public string Name { get;private set; }
        public int Bitcoins { get;private set; }

        public WaletS(string name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

        public void Debit(int amount)
        {
            Bitcoins -= amount;
        }
        public void Credit(int amount)
        {
          Bitcoins += amount;
        }

        public void RandomTransaction()
        {
            int[] amounts = {10,20,-15,50,-10 ,60,-80};
            foreach (var item in amounts)
            {
                var absVal = Math.Abs(item);
                if (item >= 0)
                {
                    Credit(absVal);
                }else
                    Debit(absVal);
                Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}" +
                    $"ProcessorID: {Thread.GetCurrentProcessorId()}");

            }
        }

        public override string ToString()
        {
            return $"Name {Name}, Bitcions {Bitcoins}";
        }
    }

}