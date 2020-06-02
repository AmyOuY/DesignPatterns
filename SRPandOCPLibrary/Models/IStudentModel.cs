using SRPandOCPLibrary.Accounts;

namespace SRPandOCPLibrary.Models
{
    public interface IStudentModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccount ProcessAccount { get; set; }
    }
}