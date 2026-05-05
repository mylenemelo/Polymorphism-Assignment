using System;
using EmployeeApp;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();

        employee.FirstName = "Mylene";
        employee.LastName = "Melo";

        IQuittable quittableEmployee = employee;

        quittableEmployee.Quit();

        Console.ReadLine();
    }
}