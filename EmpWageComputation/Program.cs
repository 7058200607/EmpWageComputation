using System;

namespace EmpWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            EmpWageComputation empWageComputation = new EmpWageComputation();
            empWageComputation.CheckEmpIsPresentOrNot();
            empWageComputation.CalcEmpDailyWage();
            empWageComputation.CheckEmpFullOrPartTime();
            empWageComputation.UsingSwitchStatement();

        }
    }
}