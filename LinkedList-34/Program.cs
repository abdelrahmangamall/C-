namespace d34
{
    class Program
    {
        public static void Main(string[] args)
        {

            #region Defualt LinkedList
            //YTVideo[] yTVideo =
            //  {
            //  new YTVideo(){Title = "Class", Id = "V1",Duration = new TimeSpan(00,30,60) },
            //  new YTVideo(){Title = "field", Id = "V2",Duration = new TimeSpan(00,30,60) },
            //  new YTVideo(){Title = "attribute", Id = "V3",Duration = new TimeSpan(00,30,60) },
            //  new YTVideo(){Title = "method", Id = "V4",Duration = new TimeSpan(00,30,60) },
            //  new YTVideo(){Title = "struct", Id = "V15",Duration = new TimeSpan(00,30,60) },
            //  new YTVideo(){Title = "struct", Id = "V15",Duration = new TimeSpan(00,30,60) }
            //};
            //    LinkedList<YTVideo> values = new LinkedList<YTVideo>(yTVideo);
            //    print("PlayList", values); 
            #endregion
            #region LinkedList with add first and Last
            //LinkedList<YTVideo> list = new LinkedList<YTVideo>();
            //list.AddFirst(yTVideo[0]);
            //list.AddAfter(list.First, yTVideo[1]);
            //list.AddAfter(list.First.Next, yTVideo[2]);

            //var node3 = new LinkedListNode<YTVideo>(yTVideo[3]);
            //list.AddBefore(list.Last.Previous, node3);
            //list.AddBefore(list.Last, yTVideo[4]);
            //list.AddLast(yTVideo[5]);

            //print("new Linkedlist", list);
            //Console.ReadKey();

            #endregion

            customer c1 = new customer() {Name = "adly",Telephone= "011" };
            customer c2=  new customer() { Name = "yooya", Telephone = "056" };
            customer c3=  new customer() { Name = "aya", Telephone = "057" };

            List<customer> customers = new List<customer>() 
            {
              new customer() {Name = "adly",Telephone= "011" },
              new customer() {Name = "mo",Telephone= "012" },
              new customer() {Name = "adly",Telephone= "013" },
              new customer() {Name = "aya",Telephone= "014" },
              new customer() {Name = "saleh",Telephone= "015" },
              new customer() {Name = "salem",Telephone= "016" },
              new customer() {Name = "noah",Telephone= "017" },
              new customer() {Name = "yonis",Telephone = "018"},
            };

            #region hashset  
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));
            var hashset1 = new HashSet<customer>(customers);
            var hashset2 = new HashSet<customer>() { c3 };
            hashset1.Add(c1); // this obj is duplicated // will not added to hashset
            hashset1.Add(c2);
            var hash = hashset1.Union(hashset2);
            Console.WriteLine("HashSet");
            Console.WriteLine("-------");
            foreach (customer customer in hashset1) Console.WriteLine(customer);
            Console.WriteLine(".........................");
            foreach (customer customer in hash) Console.WriteLine(customer);
            #endregion

            #region sortedset

            Console.WriteLine("sortedSet");
            Console.WriteLine("-------");
            var customerSortedSet = new SortedSet<customer>(customers);
            customerSortedSet.Add(c1); // not accebtalbe why--->
                                       // because it will duplicate data and this not accepted for sortedset

            customerSortedSet.Add(c2); // will be added
            foreach (var customer in customerSortedSet) Console.WriteLine(customer);
            // منغير معمل اى حاجه هما كدا اترتبو عن طربق
            //Icompareable 
            #endregion
        }

        static void print(string title, LinkedList<YTVideo> playList)
        {
            Console.WriteLine($"┌{title}");
            foreach (YTVideo video in playList) 
            {
                Console.WriteLine($"{video}");
                Console.Write("└");
            }
            Console.WriteLine($"total: {playList.Count} item(s).");

        }
    }

    class customer : IComparable<customer>
    {
        public string Name { get; set; }
        public string Telephone { get; set; }

        public override int GetHashCode()
        {
            var hash = 7;
             hash = hash * 73 + Telephone.GetHashCode();
            return hash;
        }

        public override bool Equals(object? obj)
        {
            var c = obj as customer;

            if (c == null)
                return false;

            return this.Telephone.Equals(c.Telephone);
        }

        public override string ToString()
        {
            return $"{Name}, ({Telephone})";
        }

        public int CompareTo(customer? other)
        {
            if(object.ReferenceEquals(this, other)) return 0 ;
            if(other is null) return -1 ;
            return this.Name.CompareTo(other.Name);
        }
    }
    
    class YTVideo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }

        public override string ToString()
        {
            return $"├──{Title}({Duration})\n|\t{Id}";
        }
    }
}
