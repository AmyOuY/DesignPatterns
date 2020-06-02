using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class Executive : BaseEmployee, ISupervisor
    {
        public override void CalculateSalary(int rank)
        {
            decimal baseSalary = 300.0M;

            Salary = baseSalary * rank;
        }

        public void Supervise()
        {
            Console.WriteLine("I am supervising new supervisors");
        }

        public void MakePlan()
        {
            Console.WriteLine("I am making plan for next fiscal year");
        }
        
    }
}
