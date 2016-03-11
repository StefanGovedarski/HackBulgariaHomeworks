using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.FirstName = "Stefan";
            emp.LastName = "Govedarski";
            emp.Salary = 3000;
            emp.Bonus = 1000;
            emp.Position = "Chief";
            emp.PrintName();
            emp.CalculateBalance();
        }
    }
}
