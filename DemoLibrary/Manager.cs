using System;
using DemoLibrary.Interfaces;

namespace DemoLibrary
{
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75m;
            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I am reviewing a direct report's performance.");
        }
    }
}