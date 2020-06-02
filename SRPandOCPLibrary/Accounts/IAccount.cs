using SRPandOCPLibrary.Models;

namespace SRPandOCPLibrary.Accounts
{
    public interface IAccount
    {
        GraduateStudentModel Create(IStudentModel student);
    }
}