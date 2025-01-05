using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_13
{
    public class report
    {
        public delegate bool testDelegate(Employee e);

        public void processing(String title, Employee[] emp, testDelegate test )
        {
            Console.WriteLine(title);
            foreach(var e in emp)
            {
                if (test(e))
                {
                Console.WriteLine(
                    $"Id: {e.Id}," +
                    $" Name: {e.Name}," +
                    $" Gender: {e.Gender}," +
                    $" Total Sales: {e.TotalSales}");

                }

            }
            Console.WriteLine("\n\n");
        }
            
            
    }

}
