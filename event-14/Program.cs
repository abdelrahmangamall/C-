namespace day14
{
    class program
    {
        public static void Main(string[] args)
        {

        }
    }

    public delegate void stockpricechange(stock stock,decimal oldprice);

   public class stock
    {
        public string name;
        public decimal price;

        public event stockpricechange eventchange;
        public decimal Price { get => price ; set => price=value ; }
        public string Name { get => this.name; }
        public stock(string stockName)
        {
          this.name = stockName;
        }

        public void changestockPrice(decimal precent)
        {
            decimal oldprice = this.Price;
            price= Math.Round(price*precent,2);
            if (eventchange != null)
            {
                eventchange(this, oldprice);
            }
        }
    }
}