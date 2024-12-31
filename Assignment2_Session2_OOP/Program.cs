using System.Drawing;

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
            const int size = 3;
            Person[] persons = new Person[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter Name of Person {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter Age of Person {i + 1}:");
                int age = int.Parse(Console.ReadLine());

                persons[i] = new Person(name, age);
            }

            Console.WriteLine("\nDetails of Persons:");
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

            Person oldestPerson = GetOldestPerson(persons);
            Console.WriteLine($"\nThe Oldest Person is: {oldestPerson}");







            #endregion



            #endregion
        }
    }
}
