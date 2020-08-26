using DelegateLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateWinForm
{
    public partial class DelegateDemoForm : Form
    {
        CompletedCoursesModel completedCourses = new CompletedCoursesModel();
        public DelegateDemoForm()
        {
            InitializeComponent();

            PopulateCoursesWithDemoData();
        }

        private void messageBoxButton_Click(object sender, EventArgs e)
        {
            float gpa = completedCourses.GetGPA(GeneralInfo, ComputeGPA, PrintAlert);

            MessageBox.Show($"Your GPA is {gpa}");
        }

        private void textBoxButton_Click(object sender, EventArgs e)
        {
            float gpa = completedCourses.GetGPA(
                (totalCourses, totalCredits) => {
                    totalCoursesValue.Text = $"{totalCourses}";
                    totalCreditsValue.Text = $"{totalCredits}";
                },
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
                            totalPoints += credit * 2.5F;
                        }
                        else
                        {
                            totalPoints += credit * 1.0F;
                        }
                    }
                    return totalPoints / totalCredits;
                },
                (message) => { }
                );

            GPAValue.Text = $"{gpa}";
        }


        private void GeneralInfo(int totalCourses, int totalCredits)
        {
            MessageBox.Show($"You completed {totalCourses} courses with {totalCredits} credits");
        }


        public static void PrintAlert(string message)
        {
            MessageBox.Show(message);
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
                    totalPoints += credit * 2.0F;
                }
                else
                {
                    totalPoints += credit * 1.0F;
                }
            }
            return totalPoints / totalCredits;
        }

        private void PopulateCoursesWithDemoData()
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
