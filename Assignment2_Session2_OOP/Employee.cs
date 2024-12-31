using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Session2_OOP
{
    enum Gender
    {
        M , F
    }

    enum SecurityLevel
    {
        guest, Developer, secretary , DBA
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender Gender { get; set; }


        public Employee(int id , string name , SecurityLevel securityLevel , double salary , HiringDate hirdate , Gender gender)
        {
            Id = id;    
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hirdate;
            Gender = gender;
        }

       

        public override string ToString()
        {
      
            return String.Format($"Id: {Id}\n" +
                        $"Name: {Name}\n" +
                        $"Security Level: {SecurityLevel}\n" +
                        $"Salary: {Salary:C}\n" +  // Formats salary as currency
                        $"Hire Date: {HireDate:MM/dd/yyyy}\n" +  // Formats date as MM/dd/yyyy
                        $"Gender: {Gender}");
        }

    }
}
