namespace Assignment2_Session2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            // Separate Date Definition [Attribute] From Its Use [Getter Setter , Property]
            // Encapsulation With Getter Setter
            Employee employee = new Employee();
            employee.SetName("Eman");
            Console.WriteLine(employee.GetName());

            // Encapsulation With Property
            employee.Salary = 2000;
            Console.WriteLine(employee.Salary);
            employee.Age = 30;



            #endregion

            #region Indexer
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.AddPerson(0, "Ahmed", 123);
            phoneBook.AddPerson(1, "Amr", 456);
            phoneBook.AddPerson(2, "Aya", 789);

            Console.WriteLine(phoneBook["Amr"]);
            #endregion

            #region Class
            Car car = new Car(1,"BMW" , 390);
            Console.WriteLine(car);

            #endregion

        }
    }
}
