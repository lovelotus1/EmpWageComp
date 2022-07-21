using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpAttendance
    {
        const int EMP_FULL_TIME = 1;
        const int EMP_PART_TIME = 2;
        const int EMP_WAGE_PER_HR = 20;
        static int daily_Emp_wage = 0;
        static int empHrs = 0;
        public static void GetEmpAttendance()
        {
            Random random = new Random();
            int randomInt = random.Next(0, 3);

            switch (randomInt)
            {
                case EMP_FULL_TIME:
                    empHrs = 8;
                    break;
                case EMP_PART_TIME:
                    empHrs = 4;
                    break;
                default: 
                    empHrs = 0;
                    break;
            }
            daily_Emp_wage = empHrs * EMP_WAGE_PER_HR;
            Console.WriteLine("Emp Wage is :" + daily_Emp_wage);
        }
    }
}