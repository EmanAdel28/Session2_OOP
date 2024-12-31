using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Session2_OOP
{
    internal struct Employee
    {
        //Attributes Will Private
         int Id;
         string Name;
         decimal salary;
        public int Age { get; set; } //Automatic Property

        //2.1 Encapsulation With Getter Setter
        //Getter
        public string GetName()
        {
            return Name;
        }

        public void SetName(string _name)
        {
             Name =_name ;
        }

        //2.2 Encapsulation With Property

        // Full Property
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }


        public Employee(int _id  , string _name , decimal _salary , int _age)
        {
            Id = _id ;
            Name = _name ;
            salary = _salary ;
            Age = _age;
        }

        public override string ToString()
        {
            return $"ID : {Id} , Name :{Name} , Salary :{Salary} ";
        }
    }
}
