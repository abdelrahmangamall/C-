namespace d28
{

    class Program
    {
        static void Main()
        {
            #region DateTime
            //DateTime dt = new DateTime(2020, 1, 1, 3, 45, 05);
            //Console.WriteLine(dt);

            //DateTimeOffset dto = new DateTimeOffset(dt);
            //Console.WriteLine(dto);

            //DateTimeOffset dtoUtc = DateTimeOffset.UtcNow;

            //Console.WriteLine(dtoUtc);

            //TimeSpan time = new TimeSpan(1, 2, 3);
            //dto = dto.Add(time);
            //Console.WriteLine(dto);

            //Console.WriteLine($"is week end : {ProgramBase.isweekend(dt)}"); //the defination before extention method 
            //Console.WriteLine($"is week day : {dt.isweekend()}"); // the defination after extention method 
            #endregion

            pizza p = new pizza();
            p = PizzaExtentions.addDough(
                PizzaExtentions.addSauce(
                    PizzaExtentions.addCheese(
                        PizzaExtentions.addTopping(p,"Olives",5.0m),true)), "Thin");
            Console.WriteLine(p);
            
            p.addDough("Thick").addSauce().addCheese(false).addTopping("Mushrooms", 4.5m); // with extention method
        }                                                                                  
    }
    static class PizzaExtentions
    {
        public static pizza addDough(this pizza value, string type)
        {
            value.content += $"\n with {type} dough x 2.5$";
            value.Price += 2.5m;
            return value;
        }
        public static pizza addSauce(this pizza value)
        {
            value.content += $"\n Tomato sauce X $2.00";
            value.Price += 2m;
            return value;
        }
        public static pizza addCheese(this pizza value,bool extra)
        {
            value.content += extra ? $"\n Extra cheese X $6.00": $" Normal cheese X $4.00";
            value.Price += extra ? 6m: 4m;
            return value;
        }public static pizza addTopping(this pizza value,string type,decimal price)
        {
            value.content +=$"\n {type} X {price.ToString("#.##")}$";
            value.Price += price;
            return value;
        }

    }
    public class pizza
    {
        public string content { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"{content}\n------------------------------\n it cost as total price {Price}$";
        }
    }
}