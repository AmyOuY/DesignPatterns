using SRPandOCPLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPandOCPLibrary.Accounts
{
    public class ResearchAssistantAccount : IAccount
    {
        public GraduateStudentModel Create(IStudentModel student)
        {
            GraduateStudentModel output = new GraduateStudentModel();

            output.FirstName = student.FirstName;
            output.LastName = student.LastName;
            output.Email = $"{ student.FirstName }.{ student.LastName }@mail.mcgill.ca";

            output.IsResearchAssistant = true;
            output.IsThesisStudent = true;

            return output;
        }
    }
}
