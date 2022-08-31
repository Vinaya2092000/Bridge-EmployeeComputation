using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblems
{
    public class EmpPartTime
    {
        public void EmpWage()
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int empHrs = 0;
            int empWage = 0;
            int wagePerHr = 20;
           
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
            empWage = empHrs * wagePerHr;
            Console.WriteLine("The Employee wage is: "+empWage);
        }
    }
}
