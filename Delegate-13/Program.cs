using Delegate_13;
using System.Security.Cryptography.X509Certificates;

namespace Day13
{
    class program
    {
        public static void Main(string[] args)
        {
            Employee[] emps = new Employee[]
            {
                new Employee(1, "Issam A", "M", 65000),
                new Employee(2, "Reem B", "F", 55000),
                new Employee(3, "Suzan B", "F", 60000),
                new Employee(4, "Sara A", "F", 70000),
                new Employee(5, "Salah M", "M", 80000),
                new Employee(6, "Rateb A", "M", 75000),
                new Employee(7, "Abeer C", "F", 85000),
                new Employee(8, "Marwan M", "M", 90000)
            };


            report repo = new report();
            repo.processing("Employee with Salary > 6000", emps, isgthan6000);
            repo.processing("Employee with Salary < 6000", emps,  e=>  e.TotalSales < 60000m );
            repo.processing("Employee with Salary > 60000 & <80000", emps, delegate (Employee e) { return 60000m < e.TotalSales && e.TotalSales < 80000m; });




        }
        public static bool isgthan6000(Employee e) => e.TotalSales > 60000m;
    }


}