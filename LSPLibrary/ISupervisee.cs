using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public interface ISupervisee : IEmployee
    {
        IEmployee Supervisor { get; set; }
        void AssignSupervisor(IEmployee supervisor);
    }
}
