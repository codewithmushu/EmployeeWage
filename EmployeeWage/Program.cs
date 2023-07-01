using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("ABC Company", 25, 22, 120);

            Console.WriteLine("1. Check Employee Attendance");
            Console.WriteLine("2. Calculate Daily Employee Wage");
            Console.WriteLine("3. Part time employee wage");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    employee.CheckEmployeeAttendance();
                    break;
                case 2:
                    employee.CalculateDailyEmployeeWage();
                    break;
                case 3:
                    employee.AddPartTimeEmployeeAndWage();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
