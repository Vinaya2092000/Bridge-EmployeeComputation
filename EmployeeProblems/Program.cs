namespace EmployeeProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for Attendence");
            Console.WriteLine("2 for EmpWage for full time");
            Console.WriteLine("3 for EmpWage for part time");
            Console.WriteLine("4 for Using switch case");
            Console.WriteLine("5 for 20 Working Day per Month");
            Console.WriteLine("6 for 100 hours and 20 days");
            Console.WriteLine("7 for  Use Class Method and Class Variables");
            int sh = Convert.ToInt32(Console.ReadLine());
            NewMethod(sh);
        }

        private static void NewMethod(int sh)
        {
            switch (sh)
            {
                case 1:
                    EmpPresent empPresent = new EmpPresent();
                    empPresent.Present();
                    break;
                case 2:
                    EmpFullTime empFullTime = new EmpFullTime();
                    empFullTime.EmpWage();
                    break;
            }
        }
    }
}