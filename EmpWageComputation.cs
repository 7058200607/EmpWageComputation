using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{

    public class EmpWageComputation
    {
        int WAGE_PER_HOUR = 20;
        int FULL_DAY_HOUR = 8;
        int PART_TIME_HOUR = 4;
        int Total_Day= 20;
        int Hour=100;
        bool IsPresent;
        bool IsFullTime;
        Random generateNum = new Random();
        public void CheckEmpIsPresentOrNot()
        {

            int num = generateNum.Next(0,2);
            if (num == 1)
            {
                IsPresent = true;
                Console.WriteLine("Employee is Present ");
            }
            else
            {
                Console.WriteLine("Employee is Absent");

            }
        }
        public void CalcEmpDailyWage()
        {
            int empDailyWage;
            int num = generateNum.Next(0,2);
            if (IsPresent && IsFullTime)
            {
                empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                Console.WriteLine("Employee Daily Wage is ", +empDailyWage);
            }
            else if (IsPresent && !IsFullTime)
            {
                empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;

                Console.WriteLine("Employee Daily Wage is {0}", +empDailyWage);

            }

        }
        public void CheckEmpFullOrPartTime()
        {
            int num = generateNum.Next(0,2);
            if (num == 1)
            {
                IsFullTime = true;
                Console.WriteLine("Full Time Employee ");
            }
            else
            {
                IsFullTime = false;
                Console.WriteLine("Part Time Employee ");
            }


        }
        //using Switch statement
        public void UsingSwitchStatement() 
        {
            int num = generateNum.Next(0,2);
            int empDailyWage;
            switch (num)
            { 
                case 0:
                    Console.WriteLine("Employee is Present ");
                    empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                    Console.WriteLine("Employee Daily Wage is ", +empDailyWage);
                    break;

                case 1:

                    Console.WriteLine("Part Time Employee ");
                    empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                    Console.WriteLine("Employee Daily Wage is {0}", +empDailyWage);
                    break;
               
                default:

                    Console.WriteLine("Employee is Absent");
                    break;

            }
        }

        public void MonthWage() 
        {
            int num = generateNum.Next(0,2);
            int monthWage;
            int PartTimeSalary;
            switch (num)
            {
                case 1:
                    monthWage = Total_Day * WAGE_PER_HOUR * FULL_DAY_HOUR;
                    Console.WriteLine("Monthly Wage of Full Employee is {0}", monthWage);
                    break;
                case 2:
                    PartTimeSalary = Total_Day * WAGE_PER_HOUR * PART_TIME_HOUR;
                    Console.WriteLine("Part Time Wage is {0}", PartTimeSalary);
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }        
         
           
        }
        public void MonthWageHour() 
        {
            int num = generateNum.Next(0,2);
            int MonthWagehour;

            switch (num) 
            {
                case 1 :
                    MonthWagehour =   Hour *FULL_DAY_HOUR ;
                    Console.WriteLine("Month Wage of full Time at maximum hours and days is {0}", MonthWagehour);
                    break;
                    case 2 :
                    MonthWagehour =   Hour *PART_TIME_HOUR;
                    Console.WriteLine("Month Wage of full Time at maximum hours and days is {0}", MonthWagehour);
                    break;
                default:
                    Console.WriteLine("Month Wage is 0");
                        break;
            }

        }
    }
}
