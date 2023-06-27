using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Employee
    {
        private const int WAGE_PER_HOUR = 20;
        private const int FULL_DAY_HOURS = 8;
        private const int PART_TIME_HOURS = 4;
        private const int WORKING_DAYS_PER_MONTH = 20;
        private const int MAX_WORKING_HOURS = 100;
        private const int MAX_WORKING_DAYS = 20;

        private string companyName;
        private int wagePerDay;
        private int workingDaysPerMonth;
        private int workingHours;

        public Employee(string companyName, int wagePerDay, int workingDaysPerMonth, int workingHours)
        {
            this.companyName = companyName;
            this.wagePerDay = wagePerDay;
            this.workingDaysPerMonth = workingDaysPerMonth;
            this.workingHours = workingHours;
        }
        public void CheckEmployeeAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(0, 2); // Generate 0 or 1

            switch (attendance)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is Present");
                    break;
            }
        }

        public void CalculateDailyEmployeeWage()
        {
            int dailyWage = 0;
            Random random = new Random();
            int attendance = random.Next(0, 2); // Generate 0 or 1

            switch (attendance)
            {
                case 0:
                    dailyWage = 0;
                    break;
                case 1:
                    dailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
                    break;
            }

            Console.WriteLine("Daily Employee Wage: $" + dailyWage);
        }
    }
}
