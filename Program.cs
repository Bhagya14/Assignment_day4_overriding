using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task2_day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("employee name:");
            string employeename = Console.ReadLine();

            Console.WriteLine("monthly salary:");
            double monthly_salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter type of a employee:");
            string employeetype = Console.ReadLine();
            employee obj = null;
            if (employeetype == "normal")
            {
                obj = new employee(employeename, monthly_salary);
            }
            else if (employeetype == "contract")
            {
                obj = new employee_contract(employeename, monthly_salary);
            }
            else
            {
                obj = new employee_trainee(employeename, monthly_salary);
            }
            if (obj != null)
            {
                Console.WriteLine(obj.pemployeeid);
                Console.WriteLine(obj.pemployeename);
                Console.WriteLine(obj.pmonthly_salary);

                string details = obj.getdetails();
                Console.WriteLine(details);

                string work = obj.getwork();
                Console.WriteLine(work);

                Console.WriteLine("enter noof days:");
                int days = Convert.ToInt32(Console.ReadLine());
                double salary = obj.getsalary(days);
                Console.WriteLine("salary" + salary);
                Console.ReadLine();
            }
        }
    }
}