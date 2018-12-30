using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task2_day4
{
    class employee_trainee:employee
    {
        public employee_trainee(string employeename, double monthly_salary) : base(employeename, monthly_salary)
        {
        }
        public override double getsalary(int days)
        {
            double total = (this.pmonthly_salary / 30) * days;
            return total;
        }
    }
}
