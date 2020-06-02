using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class Supervisor : Employee, ISupervisor
    {
        public override void CalculateSalary(int rank)
        {
            decimal baseSalary = 40.0M;

            Salary = baseSalary * rank;
        }

        public void Supervise()
        {
            Console.WriteLine("I am supervising new staff");
        }
    }
}
