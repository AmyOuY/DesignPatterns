using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class Employee : BaseEmployee, ISupervisee
    {
        public IEmployee Supervisor { get; set; }

        public void AssignSupervisor(IEmployee supervisor)
        {
            Supervisor = supervisor;
        }
    }
}
