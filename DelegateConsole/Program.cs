using DelegateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConsole
{
    class Program
    {
        static CompletedCoursesModel completedCourses = new CompletedCoursesModel();
        static void Main(string[] args)
        {
            PopulateCoursesWithDemoData();

            float gpa = completedCourses.GetGPA(InformUserCoursesAndCredits, ComputeGPA, AlertUserGPA);

            Console.WriteLine($"Your GPA is {gpa}");

            Console.WriteLine();

            float gpa2 = completedCourses.GetGPA(
                (totalCourses, totalCredits) => Console.WriteLine($"You completed {totalCourses} courses with {totalCredits} credits"),
                (courses, totalCredits) =>
                {
                    float totalPoints = 0;
                    foreach (CourseModel course in courses)
                    {
                        float score = course.Score;
                        int credit = course.Credit;
                        if (score >= 85)
                        {
                            totalPoints += credit * 4.0F;
                        }
                        else if (score >= 75)
                        {
                            totalPoints += credit * 3.5F;
                        }
                        else if (score >= 65)
                        {
                            totalPoints += credit * 2.0F;
                        }
                        else
                        {
                            totalPoints += credit * 1.0F;
                        }
                    }
                    return totalPoints / totalCredits;
                },
                (message) => Console.WriteLine(message)
                ); 

            Console.WriteLine($"Your GPA is {gpa2}");

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit the application...");
            Console.ReadKey();
        }


        private static void InformUserCoursesAndCredits(int totalCourses, int totalCredits)
        {
            Console.WriteLine($"You completed {totalCourses} courses with {totalCredits} credits");
        }


        public static void AlertUserGPA(string message)
        {
            Console.WriteLine(message);
        }

        public static float ComputeGPA(List<CourseModel> courses, int totalCredits)
        {
            float totalPoints = 0;
            foreach (CourseModel course in courses)
            {
                float score = course.Score;
                int credit = course.Credit;
                if (score >= 85)
                {
                    totalPoints += credit * 4.0F;
                }
                else if (score >= 75)
                {
                    totalPoints += credit * 3.5F;
                }
                else if (score >= 65)
                {
                    totalPoints += credit * 2.5F;
                }
                else
                {
                    totalPoints += credit * 1.5F;
                }
            }
            return totalPoints / totalCredits;
        }

        private static void PopulateCoursesWithDemoData()
        {
            completedCourses.Courses.Add(new CourseModel { CourseName = "Algorithm and Data Structure", Credit = 4, Score = 92 });
            completedCourses.Courses.Add(new CourseModel { CourseName = "Operating System", Credit = 4, Score = 84 });
            completedCourses.Courses.Add(new CourseModel { CourseName = "Computer Network", Credit = 3, Score = 88 });
            completedCourses.Courses.Add(new CourseModel { CourseName = "Web Development", Credit = 3, Score = 95 });
            completedCourses.Courses.Add(new CourseModel { CourseName = "Machine Learning", Credit = 4, Score = 82 });
            completedCourses.Courses.Add(new CourseModel { CourseName = "Distributed System", Credit = 4, Score = 74 });              
        }
    }
}
