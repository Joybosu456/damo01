﻿using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage problome :");

            EmployeeCheck.EmployeePresentOrNot();

            CalculateEmployeeWage.CalculateWage();

            EmployeeWage.CalEmpWage();
        }
    }
}
