using System;

namespace UC6EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int WagePer_Hour = 20;
            int FullDay_Hour = 8;
            int HalfDay_Hour = 4;
            int workingDaysPerMonth = 20;
            int totalWage = 0;
            int noOfDaysPresent = 20;
            int totalHours = 0;

            for (int i = 0; i < workingDaysPerMonth && totalHours <= 100; i++)
            {
                int number = ran.Next(0, 3);

                switch (number)
                {

                    case 0:
                        totalHours += FullDay_Hour;
                        totalWage = totalWage + (FullDay_Hour * WagePer_Hour);
                        break;

                    case 1:
                        totalHours += HalfDay_Hour;
                        totalWage += (HalfDay_Hour * WagePer_Hour);
                        break;

                    case 2:
                        noOfDaysPresent--;
                        totalWage += 0;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Number of Hours Employee worked: " + totalHours);
            Console.WriteLine("Number of Days Employee is Present: " + noOfDaysPresent + " Days");
            Console.WriteLine("total wages for the month is: " + totalWage);
            Console.ReadKey();
        }
    }
}
