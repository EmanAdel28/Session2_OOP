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

        }
    }
}
