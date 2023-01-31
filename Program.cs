using System;

namespace UC4EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int n = ran.Next(0, 3);
            int PerHour_Wage = 20;
            int FullDay_Hour = 8;
            int HalfDay_Hour = 4;


            switch (n)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is Present and Worked HalfDay :" + HalfDay_Hour * PerHour_Wage);
                    break;
                case 2:
                    Console.WriteLine("Employee is Present and Worked FullDay :" + FullDay_Hour * PerHour_Wage);
                    break;
            }
        }
    }
}
