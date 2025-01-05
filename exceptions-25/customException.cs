using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions_25
{
    internal class customException : Exception
    {
        public string location { get; set; }
        public customException(string location,string message) : base(message)
        {
            this.location = location;
            //Console.WriteLine($"Error at {location} : {message}");
        }

    }
}
