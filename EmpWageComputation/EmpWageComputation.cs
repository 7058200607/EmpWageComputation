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
        bool IsPresent;
        bool IsFullTime;
        Random generateNum = new Random();
        public void CheckEmpIsPresentOrNot()
        {

            int num = generateNum.Next(0, 2);
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
            int num = generateNum.Next(0, 2);
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
            int num = generateNum.Next(0, 2);
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
    }
}
