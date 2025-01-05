namespace d33
{
    class Program
    {
        public static void Main(string[] args)
        {

            #region pop and push
            //Stack<Common> undo = new Stack<Common>(); //back

            //Stack<Common> redo = new Stack<Common>(); //forward


            //string line;

            //while (true)
            //{
            //    Console.WriteLine("Url ('exit' to quit): ");
            //    line = Console.ReadLine().ToString().ToLower();
            //    if (line == "exit")
            //    {
            //        break;
            //    }
            //    else if (line == "back")
            //    {
            //        if (undo.Count > 0)
            //        {
            //            //var r = undo.Pop();
            //            redo.Push(undo.Pop());
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //    else if (line == "forward")
            //    {
            //        if (redo.Count > 0)
            //            undo.Push(redo.Pop());
            //        else
            //            continue;
            //    }
            //    else
            //    {
            //        undo.Push(new Common(line));
            //    }

            //    Console.Clear();
            //    print("Back", undo);
            //    print("Forward", redo); 
            // }
            #endregion

            #region peek

            Stack<int> numbers = new Stack<int>(new List<int>{ 1, 2, 3 });
              while (numbers.Count > 0)
            {
                var n = numbers.Peek();
                Console.WriteLine(n);
            }

            #endregion
        }

        static void print(string name, Stack<Common>commons)
        {
            Console.WriteLine($"{name}history");
            Console.BackgroundColor = name.ToLower() == "back" ? 
                ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
            foreach (var u in commons) 
            {
                Console.WriteLine($"\t{u}");
            }
            Console.BackgroundColor= ConsoleColor.Black;
        }
        class Common
        {
            public readonly string url;
            public readonly DateTime dateTime;
            public Common(string url)
            {
                this.url = url;
                this.dateTime = DateTime.Now;
            }



            public override string ToString()
            {
                return $"url:{url}, at{dateTime}";
            }
        }
    }
}