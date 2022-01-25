using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_To_Employee_Computation_Program
{
    class EmployeeWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        public static void EmpWage()
        {
            int FullDayHour = 8;
            int empWage = 0;
            empWage = FullDayHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
            Console.ReadKey();
        }
        public static void PartTimeEmpWage()
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PART_TIME)
                empHrs = 8;
            //else
            //empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage Of Part Time Employee: " + empWage);
            Console.ReadKey();
        }

        public static void EmpWageUsingSwitch()
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 8;
                    break;

                //default:
                    //empHrs = 0;
                    //break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage Using Switch Statement: " + empWage);
            Console.ReadKey();
        }
        public static void CalculateWagesFor20DaysInMonth()
        {

            //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {

                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 8;
                        break;
                    //default:
                        //empHrs = 0;
                        //break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage For 20 Days: " + empWage);
            }
            Console.WriteLine("Total Emp Wage For 20 Days: " + totalEmpWage);
        }
        public static void CalculateWageTill100HrsOr20IsReached()
        {

            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage 100 Hrs: " + totalEmpWage);
        }

//Find Employee Length Using Class Method
        public static int ComputeEmpWage()
        {

            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
            return totalEmpWage;
        }

// Company emplowage for multiple company
        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {

            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company: " + company + " is : " + totalEmpWage);
            return totalEmpWage;
        }




        //static void Main(String[] args)
        //{
        //    ComputeEmpWage("DMart",20,2,10);
        //    ComputeEmpWage("Reliance",10,4,20);
        //}

    }
}

