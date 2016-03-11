using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassEmployee
{
    public partial class Employee
    {
        partial void Print()
        {
            Console.WriteLine(this.FirstName + "-" + this.LastName);
        }

        public void CalculateAllIncome()
        {
            Console.WriteLine(this.Salary + this.Bonus);
        }

        public void CalculateBalance()
        {
            var income = this.Salary + this.Bonus;
            var taxRateProcent = 20;
            var incomeOutOfTaxes = income - (income * (taxRateProcent / 100.0m));
            Console.WriteLine(incomeOutOfTaxes +" taxes:"  + taxRateProcent);
        }
    }
}
