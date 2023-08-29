namespace PractisePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          const  int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
           const int Emp_Rate_Per_Hour = 20;

            int empHrs = 0;
            int empWage = 0;
            Random R=new Random();  
            int empcheck= new Random().Next(0,3);
            
            switch(empcheck)
            {
                case IS_PART_TIME :
                    empHrs=4;
                    break;
                case IS_FULL_TIME :
                    empWage=8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage :" + empWage);
        }
    }
}