﻿using System;
using DemoLibrary;
using DemoLibrary.Interfaces;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IManager accountingVP = new CEO();

            accountingVP.FirstName = "E mma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            IManaged employee = new Employee();

            employee.FirstName = "Alex";
            employee.LastName = "DC";
            employee.AssignManager(accountingVP);
            employee.CalculatePerHourRate(2);


            Console.WriteLine($"{ employee.FirstName }´s salary is ${ employee.Salary }/hour.");
            Console.ReadLine();
        }
    }
}
