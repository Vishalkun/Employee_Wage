using PractisePrograms;

namespace PractisePrograms
{
    public class EmpWageBuilderObject
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) 
        {
            this.company = company; 
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        
        public void computeEmpWage()
        {
            
         
            int empHrs = 0;
            int totalEmpHours = 0;
            int totalWorkingDays =0;
            while (totalEmpHours<= this.maxHoursPerMonth && totalWorkingDays< this.numOfWorkingDays)
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
             totalEmpWage = totalEmpHours * this.empRatePerHour;
                Console.WriteLine(" Total Emp Wage for company:"+company +"is:"+ totalEmpWage);
           
        }

        public string tostring()
        {
            return "total Emp Wage for company:" + this.company + "is:" + this.totalEmpWage;

        }
        

    }
}
class program
{
     static void Main(string[] args)
    {
        EmpWageBuilderObject dmart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
        EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
        dmart.computeEmpWage();
        Console.WriteLine(dmart.ToString());
        reliance.computeEmpWage();
        Console.WriteLine(reliance.ToString());


    }
}
