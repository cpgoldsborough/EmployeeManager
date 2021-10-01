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

            

            while (true)
            {
            Console.WriteLine("Please enter your first name and surname");
            EmployeeName = Console.ReadLine();
                if(EmployeeName.Length)
            }



            while(true)
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
                    Console.WriteLine("First letter is not a char");
                    continue;
                }

                // [1] isDigit? 

                // everythings ok
                break;

            }

            Console.WriteLine("Validation passed");
            
            //while (EmployeeID.Length == 3)
            //{
            //    char x = EmployeeID[0];
            //    if (char.IsLetter(x))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("ERROR" +
            //            "\nPlease enter a letter followed by two numbers"); ;
            //        EmployeeID = Console.ReadLine();
            //    }
            //}

            //while (EmployeeID.Length == 3)
            //{
                //int number1 = EmployeeID[1];
               // int number2 = EmployeeID[2];
               // if ((number1))
              //  {

               // }
           // }

            
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
