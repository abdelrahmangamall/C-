using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d20
{
    public abstract class employee //انا عملتهه هنا abstract عشان مش هحتاج اعمل منو obj
   {
        int id, LoggedHours,wage;
        string name, position;


        public employee(int id, string name,string position, int loggedHours,int wage)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.LoggedHours = loggedHours;
            this.wage = wage;
        }
        public decimal basicSalary() 
        {
            return wage * 176;
        } //basicSalary
        public int additionalHour()
        {
            return LoggedHours - 176;
        } //additionHours
      public decimal overtime() 
        {
            decimal overTime;
            const decimal bs = 1.25m;
            return overTime = additionalHour() * bs * wage;
        } // overtime
        public virtual decimal Netsalary() 
        {
            decimal netsal = basicSalary() + overtime();
            return netsal;
        } //netsal

        public virtual string ToString()
        {
            return $"{position} \n-------------------------- \n"+
                $"id: {id}\n"+
                $"name: \"{name}\""+
                $"\nLoggedHours: {LoggedHours} HRS\n"+
                $"wage: ${wage}/HR \n" +
                $"basic salary: ${basicSalary()} \n"+
                $"overTime: ${overtime()}\n";
        }


    }

    public class manager : employee
    {
        decimal allwance;

        public manager
            (int id, string name, int wage,decimal allwance,int loggedhours, string position) 
            : base(id, name,position,loggedhours,wage)
        {
            this.allwance = allwance;   
        }
     
        public override decimal Netsalary()
        {
            return base.Netsalary()+allwance;
        }

        public override string ToString()
        {
            return base.ToString() 
               
                + $"allwance: ${allwance}\n" +
                 $"Netsalary: ${Netsalary()} ";
                 
        }
    }
}
