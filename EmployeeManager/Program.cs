using System;

namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            String EmployeeName;
            String EmployeeID;
            double HoursWorked;
            double HourlyWage = 9.50;
            double AdditionalWage = 14.25;
            double weeklywage;
            // basic 40-hour working week
            const int basicWorkingWeek = 40;

            while (true)
            {
                Console.WriteLine("Please enter your first name and surname");
                EmployeeName = Console.ReadLine();
                if (ValidName(EmployeeName))
                {
                    Console.WriteLine("Incorrect Length");
                    continue;
                }
                break;
            }
            Console.WriteLine("Validation Passed");


            while (true)
            {
                Console.WriteLine("Please enter your employee ID , this is a singular letter followed by two digits");
                EmployeeID = Console.ReadLine();

                if (EmployeeID.Length != 3)
                {
                    Console.WriteLine("Incorrect length");
                    continue;
                }

                char x = EmployeeID[0];
                if (!char.IsLetter(x))
                {
                    Console.WriteLine("First character is not a letter, ID numbers must start with a letter");
                    continue;
                }

                char y = EmployeeID[1];

                if (!char.IsDigit(y))
                {
                    Console.WriteLine("Second character is not a number, anything after the first letter must be a number ");
                    continue;
                }
                char z = EmployeeID[2];
                if (!char.IsDigit(z))
                {
                    Console.WriteLine("Third character is not a number, anything after the first letter must be a number");
                }
                break;
            }
            Console.WriteLine("Validation passed");


            while (true)
            {
                Console.WriteLine("Please enter your hours worked weekly");
                HoursWorked = double.Parse(Console.ReadLine());
                if (HoursWorked < 1 || HoursWorked > 100)
                {
                    Console.WriteLine("Hours worked can only be between 1-100");
                    continue;
                }
                break;
            }
            Console.WriteLine("Validation Passed");
           
          
            if (HoursWorked <= basicWorkingWeek) 
            {
            weeklywage = HoursWorked * HourlyWage;
            }
            else
            {
                 double WageBeforeOvertime = basicWorkingWeek * HourlyWage;
                 double overtime = HoursWorked - basicWorkingWeek;
                 double OvertimeWage = overtime * AdditionalWage;
                 weeklywage = WageBeforeOvertime + OvertimeWage;
            }
            Console.WriteLine("Your weekly wage is: " + weeklywage);
        }

        private static bool ValidName(string EmployeeName)
        {
            return EmployeeName.Length < 1 || EmployeeName.Length > 50;
        }
    }
}
