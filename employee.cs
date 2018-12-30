using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task2_day4
{
    class employee
    {
        private int employeeid;
        private string employeename;
        private double monthly_salary;
        public static int count = 1000;
        public employee(string employeename, double monthly_salary)
        {
            this.employeeid = employee.count;
            this.employeename = employeename;
            this.monthly_salary = monthly_salary;
        }
        public int pemployeeid
        {
            get
            {
                return this.employeeid;
            }
        }
        public string pemployeename
        {
            get
            {
                return this.employeename;
            }
        }
        public double pmonthly_salary
        {
            get
            {
                return this.monthly_salary;
            }
        }
        public string getdetails()
        {
            return this.employeeid + " " + this.employeename;
        }
        public string getwork()
        {
            return "dotnet developer";
        }
        public virtual double getsalary(int days)
        {
            int bonus = 1000;
            int TDS = 800;
            double total = (this.monthly_salary / 30) * days + bonus - TDS;
            return total;
        }
    }
}
