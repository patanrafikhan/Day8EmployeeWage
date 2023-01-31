using System;

namespace UC5EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int PerHour_Wage = 20;
            int FullDay_Hour = 8;
            int HalfDay_Hour = 4;
            int MonthlyWage = 0;
            int Wage = 0;
            int day = 0;
            int count = 1;

            while (day != 20 && count != 30)
            {
                int n = ran.Next(0, 3);
                switch (n)
                {
                    case 0:
                        count++;
                        break;
                    case 1:
                        Wage = HalfDay_Hour * PerHour_Wage;
                        MonthlyWage = Wage + MonthlyWage;
                        count++;
                        day++;
                        break;
                    case 2:
                        Wage = FullDay_Hour * PerHour_Wage;
                        MonthlyWage = Wage + MonthlyWage;
                        count++;
                        day++;
                        break;

                }

            }
            Console.WriteLine("Employee Monthly Wage is :" + MonthlyWage);
            Console.WriteLine("EMployee Prasent Days :" + day);
            Console.ReadKey();
        }
    }
}
