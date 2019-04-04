using System;
using DemoLibrary;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "E mma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            BaseEmployee employee = new CEO();

            employee.FirstName = "Alex";
            employee.LastName = "DC";
            //employee.AssignManager(accountingVP);
            employee.CalculatePerHourRate(2);


            Console.WriteLine($"{ employee.FirstName }´s salary is ${ employee.Salary }/hour.");
            Console.ReadLine();
        }
    }
}
