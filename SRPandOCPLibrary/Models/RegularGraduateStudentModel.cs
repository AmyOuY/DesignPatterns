using SRPandOCPLibrary.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPandOCPLibrary.Models
{
    public class RegularGraduateStudentModel : IStudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount ProcessAccount { get; set; } = new Account();
    }
}
