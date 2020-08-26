using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLibrary
{
    public class CompletedCoursesModel
    {
        public delegate void MentionTotalCoursesAndCredits(int totalCourses, int totalCredits);
        public List<CourseModel> Courses { get; set; } = new List<CourseModel>();

        public float GetGPA(MentionTotalCoursesAndCredits mentionTotalCoursesAndCredits,
            Func<List<CourseModel>, int, float> calculateGPA,
            Action<string> tellUserAboutGPAScale)
        {
            int totalCourses = Courses.Count;
            int totalCredits = Courses.Sum(x => x.Credit);

            mentionTotalCoursesAndCredits(totalCourses, totalCredits);

            tellUserAboutGPAScale("We are calculating your GPA based on a 4.0 scale.");

            return calculateGPA(Courses, totalCredits);
        }
    }
}
