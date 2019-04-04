using System;
using DemoLibrary.Interfaces;

namespace DemoLibrary
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150m;
            Salary = baseAmount * rank;
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