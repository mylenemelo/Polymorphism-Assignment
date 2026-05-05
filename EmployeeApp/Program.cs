using System; // Allows use of Console

// Interface definition
interface IQuittable
{
    void Quit(); // Method that must be implemented by any class using this interface
}

// Employee class implementing IQuittable interface
class Employee : IQuittable
{
    // Property for first name
    public string FirstName { get; set; }

    // Property for last name
    public string LastName { get; set; }

    // Implementation of Quit method from interface
    public void Quit()
    {
        // Message displayed when employee quits
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.FirstName = "Mylene";
        emp.LastName = "Melo";

        IQuittable quittableEmployee = emp;
        quittableEmployee.Quit();

        Console.ReadLine();
    }
}
