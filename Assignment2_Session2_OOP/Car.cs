using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Session2_OOP
{
    internal class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }


        public Car(int id  , string model , double speed)
        {
            Id = id ;
            Model = model ;
            Speed = speed ;
        }

        public Car(int id, string model) : this(id , model , 290)
        {
            //Id = id;
            //Model = model;
            //Speed = 290;
        }

        public Car(int id) : this(id, "BMW", 290)
        {
            //Id = id;
            //Model = "BMW";
            //Speed = 290;
        }
        public override string ToString()
        {
            return $"Id : {Id} \n Model : {Model}\n Speed : {Speed}";
        }
    }

}
