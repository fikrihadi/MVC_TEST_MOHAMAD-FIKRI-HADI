using System;
using System.Collections.Generic;

namespace SalarySumApp
{
    class Program
    {
        // Employee class to store employee position and salary
        public class Employee
        {
            public string Position { get; set; }
            public int Salary { get; set; }
        }

        static void Main(string[] args)
        {
            // Sample data for employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Position = "Manager", Salary = 75000 },
                new Employee { Position = "Manager", Salary = 65000 },
                new Employee { Position = "Manager", Salary = 60000 },
                new Employee { Position = "Manager", Salary = 60000 },
                new Employee { Position = "Staff", Salary = 50000 },
                new Employee { Position = "Staff", Salary = 45000 },
                new Employee { Position = "Entry-Level", Salary = 32000 },
                new Employee { Position = "Entry-Level", Salary = 28000 }
            };

            // Initialize sum of salaries for managers
            int sumOfManagerSalaries = 0;

            // Loop through each employee and sum salaries for Manager position
            foreach (var employee in employees)
            {
                if (employee.Position == "Manager")
                {
                    sumOfManagerSalaries += employee.Salary;
                }
            }

            // Display the result
            if (sumOfManagerSalaries > 0)
            {
                Console.WriteLine($"Sum of Salary for Manager = {sumOfManagerSalaries}");
            }
            else
            {
                Console.WriteLine("No managers found.");
            }
        }
    }
}
