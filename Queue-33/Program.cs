namespace dq33
{
    class Program
    {
        public static void Main(string[] args)
        {

            #region EnQueue and DeQueue
            //Queue<PrintingJob> queue = new Queue<PrintingJob>();

            //queue.Enqueue(new PrintingJob("pdf", 4));
            //queue.Enqueue(new PrintingJob("doxc", 1));
            //queue.Enqueue(new PrintingJob("xlsx", 2));
            //queue.Enqueue(new PrintingJob("report", 3));
            //queue.Enqueue(new PrintingJob("ppt", 5));
            //queue.Enqueue(new PrintingJob("pdf2", 6));
            //Console.WriteLine(queue.Count);
            //while (queue.Count > 0)
            //{
            //    var n = queue.Dequeue();
            //    Console.WriteLine(n);
            //    queue.Enqueue(n);
            //}
            //Console.WriteLine(queue.Count); 
            #endregion


            Queue<int> number = new Queue<int>();

            if (number.TryDequeue(out int n))
            {
                Console.WriteLine(n);
            }else
                Console.WriteLine("Queue is Empty...");

        }

    }
    class PrintingJob
    {
        private readonly string file;
        private readonly int copies;

        public PrintingJob(string file, int copies)
        {
            this.file = file;
            this.copies = copies;
        }

        public override string ToString()
        {
            return  $"{file} x #{copies}";
        }
    }
}