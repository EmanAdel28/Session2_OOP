using System.Drawing;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Assignment2_Session2_OOP
{
    internal class Program
    {

        public static double GetDestanceBetweenTwoPoints(Point P1, Point P2)
        {
            double result;
            double deltaX = P1.X - P2.X;
            double deltaY = P1.Y - P2.Y;

            result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return result;

        }

        static Person GetOldestPerson(Person[] persons)
        {
            Person oldest = persons[0];
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldest.Age)
                {
                    oldest = persons[i];
                }
            }
            return oldest;
        }

        
        static void Main(string[] args)
        {
            #region Part 01

            #region Part1 Q1
            //1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.

            //bool Flag;
            //double x1 , x2 , y1 , y2;

            //Console.WriteLine("Enter Value of  X1 :");
            //do
            //{
            //    Flag = double.TryParse(Console.ReadLine(), out  x1);

            //} while (!Flag);

            //Console.WriteLine("Enter Value of Y1:");
            //do
            //{
            //    Flag = double.TryParse(Console.ReadLine(), out  y1);

            //} while (!Flag);


            //Point P01 = new Point(x1, y1);

            //Console.Write("P1 : ");
            //Console.WriteLine(P01);

            //Console.WriteLine("Enter Value of  X2 :");
            //do
            //{
            //    Flag = double.TryParse(Console.ReadLine(), out x2);

            //} while (!Flag);

            //Console.WriteLine("Enter Value of Y2:");
            //do
            //{
            //    Flag = double.TryParse(Console.ReadLine(), out y2);

            //} while (!Flag);

            //Point P02 = new Point(x2, y2);
            //Console.Write("P2 : ");
            //Console.WriteLine(P02);

            //Console.WriteLine("Distance Between Two Points");
            //Console.WriteLine(GetDestanceBetweenTwoPoints(P01, P02));
            #endregion

            #region Part1 Q2
            // 2.Create a struct called "Person" with properties "Name" and "Age".
            // Write a C# program that takes details of 3 persons as input from the user
            // and displays the name and age of the oldest person.

            //const int size = 3;
            //Person[] persons = new Person[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter Name of Person {i + 1}:");
            //    string name = Console.ReadLine();

            //    Console.WriteLine($"Enter Age of Person {i + 1}:");
            //    int age = int.Parse(Console.ReadLine());

            //    persons[i] = new Person(name, age);
            //}

            //Console.WriteLine("\nDetails of Persons:");
            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            //Person oldestPerson = GetOldestPerson(persons);
            //Console.WriteLine($"\nThe Oldest Person is: {oldestPerson}");



            #endregion



            #endregion

            #region Part 02

            #region part2 Q1

            //1.Design and implement a Class for the employees in a company:
            // Notes:
            //=> Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //=> We need to restrict the Gender field to be only M or F[Male or Female]
            //=> Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
            //=> We want to provide the Employee Class to represent Employee data in a string Form(override ToString()),
            //display employee salary in a currency format. [Use String.Format() Function].
            HiringDate hireDate1 = null;
            HiringDate hireDate2 = null;
            HiringDate hireDate3 = null;

            try
            {
                 hireDate1 = new HiringDate(2, 1, 2024); // Invalid month
                 hireDate2 = new HiringDate(20, 3, 2023); // Invalid month
                 hireDate3 = new HiringDate(16, 5, 2022); // Invalid month
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message); // Will print: "Month must be between 1 and 12."
            }

            Employee[] employee = new Employee[3];

            employee[0] =new Employee(1, "Eman", SecurityLevel.Developer, 20000, hireDate1, Gender.F);
            employee[1] =new Employee(2, "Amira", SecurityLevel.Developer, 30000, hireDate2, Gender.F);
            employee[2] =new Employee(3, "Nohammed", SecurityLevel.Developer, 40000, hireDate3, Gender.M);

            //for(int i = 0; i < employee.Length; i++)
            //{
            //    Console.WriteLine(employee[i]);

            //}

            Console.WriteLine("Before Sorting:");
            foreach (var emp in employee)
            {
                Console.WriteLine(emp);
            }

            // Sorting based on HireDate and counting boxing/unboxing
            int boxingCount = 0;
            Array.Sort(employee, (x, y) =>
            {
                boxingCount++; // Boxing during comparison
                return x.HireDate.CompareTo(y.HireDate);
            });

            Console.WriteLine("\nAfter Sorting:");
            foreach (var emp in employee)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine($"\nNumber of times boxing occurred during sorting: {boxingCount}");
        
        #endregion
        #endregion
    }
    }
}
