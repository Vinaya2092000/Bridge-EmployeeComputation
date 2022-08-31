using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblems
{
    public class EmpFullTime
    {
        public void EmpWage()
        {
            int FULL_TIME = 1;
            int empHrs = 0;
            int wagePerHr = 20;
            int empWage = 0;
            Random random = new Random();
            int Check = random.Next(0, 2);
            if (Check == FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present");
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
