using exceptions_25;

namespace d25
{
    partial class Program
    {
        static void Main(string[] args)
        {
            #region try-catch
            //try
            //{
            //    int res = BadMethod(5, 0);
            //    Console.WriteLine(res);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block");
            //} 
            #endregion
            var delivery = new delivery("Delivery1", "Address1", "Customer1");
            //Console.WriteLine(delivery.ToString());
            var service = new deliveryService();
            service.start(delivery);

        }

        static int BadMethod(int x, int y)
        {
            return x / y;
        }
    }
}