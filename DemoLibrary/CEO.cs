using System;

namespace DemoLibrary
{
    public class CEO : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150m;
            Salary = baseAmount * rank;
        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager;");
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I am reviewing a direct report's performance.");
        }

        public void FireSomeOne()
        {
            Console.WriteLine("You are Fired!");

        }
    }
}