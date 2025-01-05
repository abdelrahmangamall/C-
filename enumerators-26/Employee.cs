namespace d26
{
    public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; } 
       public string department { get; set; }
       public int salary { get; set; }

        public Employee(string name, string department, int salary,int id)
        {
            this.Id = id;
            Name = name;
            this.department = department;
            this.salary = salary;
        }

        public static bool operator == (Employee emp1, Employee emp2) => emp1.Equals(emp2);
        //{
        //    return emp1.Id == emp2.Id
        //        && emp1.Name == emp2.Name
        //        && emp1.department == emp2.department
        //        && emp1.salary == emp2.salary;
        //}
        public static bool operator !=(Employee emp1, Employee emp2) => !emp1.Equals(emp2);
        //{
        //    return emp1.Id != emp2.Id
        //        || emp1.Name != emp2.Name
        //        || emp1.department != emp2.department
        //        || emp1.salary != emp2.salary;
        //}
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Id.GetHashCode();
            return hash;
        }
        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Employee))
                return false;

            var emp = (Employee)obj; //way1
            var em = obj as Employee; //way2

            return this.Id == emp.Id
                && this.Name == emp.Name
                && this.department==emp.department
                && this.salary == emp.salary;
        }
    }
}