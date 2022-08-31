using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblems
{
    public class Hours100
    {
        public void Hundred()
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int empHrs = 0;
            int empWage = 0;
            int wagePerHr = 20;
            int totalWorkingdays = 20;
            int totalWorkingHrs = 100;
            int totalEmpHrs = 0;
            int totalDays = 0;
            do
            {
                Random random = new Random();
                int Check = random.Next(0, 3);
                if (Check == FULL_TIME)
                {
                    empHrs = 8;
                    Console.WriteLine($"Full time employee");
                }
                else if (Check == PART_TIME)
                {
                    empHrs = 4;
                    Console.WriteLine("Part time employee");
                }
                else
                {
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                empWage = empHrs * wagePerHr;
                Console.WriteLine("The Employee wage is: " + empWage);
                totalDays++;
            }
            while (totalEmpHrs <= totalWorkingHrs && totalDays < totalWorkingdays);
            Console.WriteLine("The total working days per month is"+totalWorkingdays+"and total working hours is"+totalEmpHrs);
            empWage = totalEmpHrs* wagePerHr;
            Console.WriteLine("Employee wage is"+empWage);
        }
    }
}
