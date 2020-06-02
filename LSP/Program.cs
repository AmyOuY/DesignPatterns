using LSPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Supervisor ITManager = new Supervisor();
            //ISupervisor ITManager = new Supervisor();
            //ISupervisor ITManager = new Executive();
            ITManager.FirstName = "Mia";
            ITManager.LastName = "Terry";
            ITManager.CalculateSalary(6);

            //Employee employee = new Employee();
            //ISupervisee employee = new Employee();
            Employee employee = new Supervisor();         
            employee.FirstName = "Sue";
            employee.LastName = "Cameron";
            employee.CalculateSalary(4);
            employee.AssignSupervisor(ITManager);

            Console.WriteLine($"{ employee.FirstName }'s salary is ${ employee.Salary }/Hour with supervisor { ITManager.FirstName }");
            Console.ReadLine();
        }
    }
}
