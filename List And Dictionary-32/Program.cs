namespace d32
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LIST
            //Country egypt = new Country
            //{
            //    ISOcode = "EGY",
            //    Name = "Egypt"
            //};
            //Country jordan = new Country
            //{
            //    ISOcode = "JOR",
            //    Name = "Jordan"
            //}; Country iraq = new Country
            //{
            //    ISOcode = "IRQ",
            //    Name = "Iraq"
            //};

            //Country[] arr = new Country[]  // array of objects
            //{
            //    egypt,
            //    jordan,
            //    iraq
            //};
            ////constructor in list
            //List<Country> list = new List<Country>();
            //List<Country> list1 = new List<Country>(4);
            //List<Country> list2 = new List<Country>(arr);
            ////properties

            ////method on list
            //list.Add(egypt);

            //list.Add(new Country { ISOcode = "helw", Name = "Helwan" });
            //list.AddRange(arr);
            //list.Insert(1, new Country { ISOcode = "KSA", Name = "KSA" });
            //list.InsertRange(2, arr);

            ////list.RemoveAt(3); //remove by index
            //list.Remove(egypt); //remove by object
            //list.Remove(new Country()
            //{
            //    ISOcode = "EGY",
            //    Name = "Egypt"
            //});
            //list.RemoveAll(x => x.Name == "Jordan");

            //print(list); 
            #endregion

            #region Dictionary

            //var str = "We received an overwhelming response to the Junior Backend position, which makes us feel both humble and proud that so many talented individuals (like you!) want to join our team." +
            //    " This volume of response makes for an extremely competitive selection process. Although your background is impressive," +
            //    " we regret to inform you that we have decided to pursue other candidates for the position at this time.";
            //Dictionary<char, List<string>> letterDictionary = new Dictionary<char, List<string>>();

            //foreach (var word in str.Split())
            //{
            //    foreach (var ch in word)
            //    {
            //        char c = char.ToLower(ch);
            //        if (!letterDictionary.ContainsKey(c))
            //        {
            //            letterDictionary.Add(c, new List<string> { word });
            //        }
            //        else
            //            letterDictionary[c].Add(word);
            //    }
            //}

            //foreach (var entry in letterDictionary)
            //{
            //    Console.WriteLine($"{entry.Key} : ");
            //    foreach (var word in entry.Value)
            //    {
            //        Console.WriteLine($"\t{word} ");
            //    }

            #endregion

            var emp = new employee();
            var em = new List<employee>()
            {
                new employee{id = 100 , name = "may", reportTo = null } ,
                new employee{id = 101 , name = "ali", reportTo = 100 } ,
                new employee{id = 102 , name = "slma", reportTo = 100 } ,
                new employee{id = 103 , name = "soad", reportTo = 102 } ,
                new employee{id = 104 , name = "salem", reportTo = 102 } ,
                new employee{id = 105 , name = "mo", reportTo = 101 } ,
                new employee{id = 106 , name = "abrove", reportTo = 104 } 
            };
            var empDic = em.GroupBy(x => x.reportTo).ToDictionary(x=>x.Key?? -1,x=>x.ToList());

            Console.ReadKey();
        }


            static void print(List<Country> countries)
            {
                foreach (Country country in countries)
                {
                    Console.WriteLine(country);
                }
                //properties in list
                Console.WriteLine(countries.Count);
                Console.WriteLine(countries.Capacity);
            }
        
        public class employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public int? reportTo { get; set; }

            public override string ToString()
            {
                return $"{id} {name} {reportTo}";
            }
        }
        class Country
        {
            public string Name { get; set; }
            public string ISOcode { get; set; }

            public override int GetHashCode()
            {
                int hash = 13;
                hash = (hash * 7) + Name.GetHashCode();
                hash = (hash * 7) + ISOcode.GetHashCode();
                return hash;
            }
            public override bool Equals(object? obj)
            {
                var country = obj as Country;
                if (country is null)
                    return false;
                return Name == country.Name && ISOcode == country.ISOcode;





            }
            public override string ToString()
            {
                return $"{Name},{ISOcode}";
            }
        }

    }
}
