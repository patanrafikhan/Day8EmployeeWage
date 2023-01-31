using System;

namespace UC3EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int n = ran.Next(0, 3);
            int WagePerHour = 20;
            int FullDayHour = 8;
            int PartTimeHour = 4;

            if (n == 0)
            {
                Console.WriteLine("Employee is Present and Worked FullTime");
                Console.WriteLine("Daily Wage is : " + WagePerHour * FullDayHour);
            }
            else if (n == 1)
            {
                Console.WriteLine("Employee is Present and Worked PartTime");
                Console.WriteLine("PartTime Wage is :" + WagePerHour * PartTimeHour);
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
            Console.ReadKey();
        }
    }
}
