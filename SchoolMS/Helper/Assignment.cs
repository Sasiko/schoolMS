using SchoolMS.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS.Helper
{
    public class Assignment:IAssignment
    {
        private string marks = "0";
        public string AssignmentName { get; set; }
        public string Marks { get { return marks; } set { marks = value; } }
        //Tilldela labb uppgift  
        public void AddAssignment(string name, string courseName, DataStore dataStore)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Assignment assignment = new Assignment();
                assignment.AssignmentName = name;
                assignment.Marks = "0";
                var obj = dataStore.Courses.Where(x => x.CourseName == courseName)?.FirstOrDefault();
                if (obj.Assignments == null)
                {
                    obj.Assignments = new List<Assignment>();
                    obj.Assignments.Add(assignment);
                }
                else
                    obj.Assignments.Add(assignment);
                MessageBox.Show("Assigned Successfully");
            }
            else
            {
                MessageBox.Show("Please Enter the name");
            }
        }
        //Uppdatera betyget för student på labb och slubbetyget  
        public void UpdateGrade(string courseName, string StudentName, string AssignmentName, string AssignmentMarks, string CourseMarks, DataStore dataStore)
        {
            foreach (var course in dataStore.Courses)
            {
                if (course.CourseName == courseName)
                {
                    foreach (var student in course.Students)
                    {
                        if (student.StudentName == StudentName)
                        {
                            course.CourseMarks = CourseMarks;
                            foreach (var assignement in course.Assignments)
                            {
                                if (assignement.AssignmentName == AssignmentName)
                                    assignement.Marks = AssignmentMarks;
                            }
                            MessageBox.Show("Marks Updated...!");
                        }

                    }
                }

            }
        }
    }
}
