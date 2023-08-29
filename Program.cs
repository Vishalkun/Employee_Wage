namespace PractisePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          const  int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
           const int Emp_Rate_Per_Hour = 20;
            const int NO_OF_WORKING_DAYS = 2;
            const int MAX_HOURS_IN_MONTH = 10;

            int empHrs = 0;
            int totalEmpHours = 0;
            int totalWorkingDays =0;
            while (totalEmpHours<= MAX_HOURS_IN_MONTH  && totalWorkingDays< NO_OF_WORKING_DAYS)
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
            int totalEmpWage = totalEmpHours * Emp_Rate_Per_Hour;
                Console.WriteLine(" Total Emp Wage :" + totalEmpWage);

        }

    }

}
