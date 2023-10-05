using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace CalculateEmpWages
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string compnay, int wage_per_hour, int no_of_working_days, int max_hrs_in_month);
        public void ComputeEmpWage();
        public void getTotalWage();
    }
    public class CompanyEmpWage
    {
        public string company;
        public int wage_per_hour;
        public int no_of_working_days;
        public int max_hrs_in_month;
        public int total_wage;
        public CompanyEmpWage(string compnay, int wage_per_hour, int no_of_working_days, int max_hrs_in_month)
        {
            this.company = compnay;
            this.wage_per_hour = wage_per_hour;
            this.no_of_working_days = no_of_working_days;
            this.max_hrs_in_month = max_hrs_in_month;

        }
        public void setTotalEmpWage(int total_wage)
        {
            this.total_wage = total_wage;
        }
        public string toString()
        {
            return "total emp wage for company " + this.company + " is " + this.total_wage;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            EmpWageBulderArray empWageBulder = new EmpWageBulderArray();

            empWageBulder.addCompanyEmpWages("Smart", 25, 20, 90);
            empWageBulder.addCompanyEmpWages("reliance", 20, 22, 100);

            empWageBulder.computeEmpWage();






        }
    }

    public class EmpWageBulderArray
    {
        public const int is_full_time = 1;

        public const int is_part_time = 2;

        private int no_of_companys = 0;

        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBulderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWages(string compnay, int wage_per_hour, int no_of_working_days, int max_hrs_in_month)
        {
            companyEmpWageArray[this.no_of_companys] = new CompanyEmpWage(compnay, wage_per_hour, no_of_working_days, max_hrs_in_month);
            no_of_companys++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < no_of_companys; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int total_hours_per_day = 0;

            int total_working_days = 0;

            int emp_hours = 0;

            while (emp_hours <= companyEmpWage.max_hrs_in_month && total_working_days < companyEmpWage.no_of_working_days)
            {
                total_working_days++;

                Random random = new Random();

                int emp_check = random.Next(0, 3);

                switch (emp_check)
                {
                    case is_full_time:
                        total_hours_per_day = 8;
                        break;
                    case is_part_time:
                        total_hours_per_day = 4;
                        break;
                    default:
                        total_hours_per_day = 0;
                        break;

                }
                emp_hours += total_hours_per_day;


                Console.WriteLine("day " + total_working_days + " emp hrs : " + emp_hours);

            }


            return emp_hours * companyEmpWage.wage_per_hour;

        }
    }




}