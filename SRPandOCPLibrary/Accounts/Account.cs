using SRPandOCPLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPandOCPLibrary.Accounts
{
    public class Account : IAccount
    {
        public GraduateStudentModel Create(IStudentModel student)
        {
            GraduateStudentModel output = new GraduateStudentModel();

            output.FirstName = student.FirstName;
            output.LastName = student.LastName;
            output.Email = $"{ student.FirstName }.{ student.LastName }@mail.mcgill.ca";

            return output;
        }
    }
}
