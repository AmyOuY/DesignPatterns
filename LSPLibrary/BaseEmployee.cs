using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculateSalary(int rank)
        {
            decimal baseSalary = 20.0M;

            Salary = baseSalary * rank;
        }
    }
}
