﻿namespace PractisePrograms
{
    internal class Program
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        
        public static int computeEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            
         
            int empHrs = 0;
            int totalEmpHours = 0;
            int totalWorkingDays =0;
            while (totalEmpHours<= maxHoursPerMonth && totalWorkingDays< numOfWorkingDays)
            {
                totalWorkingDays++;
                Random R = new Random();
                int empcheck = new Random().Next(0, 3);

                switch (empcheck)
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
                totalEmpHours += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHours * empRatePerHour;
                Console.WriteLine(" Total Emp Wage for company:"+company +"is:"+ totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("DMart",20,2,10);
            computeEmpWage("Reliance", 10, 4, 20);

        }


    }

}
