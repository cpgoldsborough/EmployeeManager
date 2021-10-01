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
            double Overtime;
            double HourlyWage = 9.50;
            double AdditionalWage = 14.25;
            double weeklywage;

            Console.WriteLine("Please enter your first name and surname");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Please enter your employee ID , this is a singular letter followed by two digits");
            EmployeeID = Console.ReadLine();
            Console.WriteLine("Please enter your hours worked weekly");
            HoursWorked = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your overtime worked hours");
            Overtime = double.Parse(Console.ReadLine());
            
            if (Overtime > 0) 
            {

                weeklywage = HoursWorked * HourlyWage + Overtime * AdditionalWage;
            }
            else
            {
                weeklywage = HoursWorked * HourlyWage;
            }
            Console.WriteLine("Your weekly wage is: " + weeklywage);
        }
    }
}
