using SRPandOCPLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPandOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IStudentModel> students = new List<IStudentModel>
            {
                new RegularGraduateStudentModel{ FirstName = "Sue", LastName = "Scarlet" },
                new TeachingAssistantModel{ FirstName = "Scott", LastName = "Katten" },
                new ResearchAssistantModel{ FirstName = "Mia", LastName = "Cotton" }
            };

            List<GraduateStudentModel> grads = new List<GraduateStudentModel>();

            foreach (var student in students)
            {
                grads.Add(student.ProcessAccount.Create(student));
            }

            foreach (var grad in grads)
            {
                Console.WriteLine($"{ grad.FirstName } { grad.LastName }: { grad.Email }   IsResearchAssistant: { grad.IsResearchAssistant }" +
                    $"  IsThesisStudent: { grad.IsThesisStudent }   IsTeachingAssistant: { grad.IsTeachingAssistant }");
            }

            Console.ReadLine();
        }

    }
}
