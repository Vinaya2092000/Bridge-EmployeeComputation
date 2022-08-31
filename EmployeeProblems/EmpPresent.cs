using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblems
{
    public class EmpPresent
    {
        public void Present()
        {
            int FULL_TIME = 1;
            Random random = new Random();
            int attendCheck = random.Next(0, 2);
            if (attendCheck == FULL_TIME)
            {
                Console.WriteLine("The Employee is present");
            }
            else
            {
                Console.WriteLine("The Employee is absent");
            }
        }
    }
}
