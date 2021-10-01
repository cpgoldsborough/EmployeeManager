using System;

namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double hours;
            double overtime;
            double HourlyWage = 9.50;
            double AdditionalWage = 14.25;
            Console.WriteLine("Please enter your hours worked weekly");
            hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your overtime worked hours");
            overtime = double.Parse(Console.ReadLine());
            double weeklywage;



            if (overtime > 0) 
            {

                weeklywage = hours * HourlyWage + overtime * AdditionalWage;
            }
            else
            {
                weeklywage = hours * HourlyWage;
            }
            Console.WriteLine("Your weekly wage is: " + weeklywage);
        }
    }
}
