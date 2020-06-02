using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPandOCPLibrary.Models
{
    public class GraduateStudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsResearchAssistant { get; set; } = false;
        public bool IsThesisStudent { get; set; } = false;
        public bool IsTeachingAssistant { get; set; } = false;
    }
}
