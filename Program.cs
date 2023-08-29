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

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage =0;
            for (int day = 1; day < NO_OF_WORKING_DAYS; day++)
            {
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
                empWage = empHrs * Emp_Rate_Per_Hour;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage :" + empWage);
            }
            Console.WriteLine(" TotalEmpWage :" + totalEmpWage);

        }

    }
}
