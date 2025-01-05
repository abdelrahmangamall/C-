using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_13
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int TotalSales { get; set; }

        public Employee(int id, string name, string gender, int totalSales)
        {
            Id = id;
            Name = name;
            Gender = gender;
            TotalSales = totalSales;
        }
    }
}
