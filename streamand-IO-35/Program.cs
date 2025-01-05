using Humanizer;
using streamand_IO_35.Models;

namespace d36
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Nuget humanizier
        //    var people = new List<Person>
        //{
        //    new Person
        //    {
        //        Owner = "Alice",
        //        Comment = "I love programming in C#!",
        //        CreatedAt = DateTime.Now.AddHours(-5)
        //    },
        //    new Person
        //    {
        //        Owner = "Bob",
        //        Comment = "C# is great for building scalable applications.",
        //        CreatedAt = DateTime.Now.AddDays(-2)
        //    },
        //    new Person
        //    {
        //        Owner = "Charlie",
        //        Comment = "I enjoy solving complex problems with code.",
        //        CreatedAt = DateTime.Now.AddMinutes(-10)
        //    },
        //    new Person
        //    {
        //        Owner = "Dana",
        //        Comment = "Exploring new frameworks is always fun.",
        //        CreatedAt = DateTime.Now.AddMonths(-1)
        //    }
        //};
        //    foreach (var person in people)
        //    {
        //        Console.WriteLine(person);
        //    } 
            #endregion


            var d = new DecimalSystem("10");
            var binary = d.To(NumberBase.Binary);
            var hexa = d.To(NumberBase.HexaDecimal);
            var Decimal = d.To(NumberBase.Decimal);
            var octal = d.To(NumberBase.Octal);
            Console.WriteLine(octal);

        }


    }
    class Person
    {
        public string Owner { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"{Owner}. Says:\n\"{Comment}\"\n\t\t\t{CreatedAt.Humanize()}";
        }
    }
}