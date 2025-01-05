namespace d27
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            Generator g = new Generator();
            var empId = g.generateId(fname, lname, dateTime);
            var password = g.generateRandomPassword(10);

            Console.WriteLine($" {fname}, {lname} , {dateTime} , {password} , {empId} ");            
        }


    }
    /// <summary>
    ///  the main Generator class
    /// </summary>
    /// <remarks> 
    ///  this class can generate id and password
    /// </remarks>
     

    public class Generator
    {
        /// <value>
        /// value of last id sequence
        /// </value>
        public int lastIdsequence
        {
            get; private set;
        } = 1;

        /// <summary>
        /// generate id for employee based on first name, last name and hire date
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="hireDate"></param>
        /// <ret urns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public string generateId(string fName, string lName, DateTime? hireDate)
        {
          if(fName is null || lName is null)
           throw new ArgumentNullException(
              $"First name {nameof(fName)} and last name {nameof(lName)} can not be null");
            if (hireDate is null)
                hireDate = DateTime.Now;
            else 
            {
            if(hireDate.Value.Date < DateTime.Now.Date)
                    throw new ArgumentException($"Hire date: {nameof(hireDate)} can not be in the past");
            }

            
            var yearofHireDate = hireDate.Value.Year;
            var monthofHireDate = hireDate.Value.Month;
            var dayofHireDate = hireDate.Value.Day;
            
             var code = 
                $"{fName.Substring(0, 1)}" +
                $"{lName.ToUpper()[0]}" +
                $"{yearofHireDate}" +
                $"{monthofHireDate}" +
                $"{dayofHireDate}" 
               +$"{(lastIdsequence++).ToString().PadLeft(2,'0')}"
                ;
            return code;
        }
       public string generateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var password =  "";
            var random = new Random();
           while(0< length--)
            {
                password += chars[random.Next(chars.Length)];
            }
            return password ;
        }

       

    }
}