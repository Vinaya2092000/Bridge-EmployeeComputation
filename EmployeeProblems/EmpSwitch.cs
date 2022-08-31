using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblems
{
    public class EmpSwitch
    {
        public void Switch()
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int empHrs = 0;
            int empWage = 0;
            int wagePerHr = 20;

            Random random = new Random();
            int Check = random.Next(0, 3);
            switch (Check)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Full time Employee");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Part time Employee");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("The Employee is absent");
                    break;
            }
            empWage = empHrs * wagePerHr;
            Console.WriteLine("The Employee wage is: "+empWage);
        }
    }
}
