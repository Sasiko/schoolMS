using SchoolMS.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS.Helper
{
    public class Student : IStudent
    {
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //public static List<StudentModel> Students = new List<StudentModel>();


        //public void addStudent(string name, string phone, string email, List<CourseModel> courses)
        //{
        //    var obj = Students?.Any(x => x.StudentName == name);
        //    if (obj == false)
        //    {
        //        StudentModel student = new StudentModel();
        //        student.StudentName = name;
        //        student.Phone = phone;
        //        student.Email = email;
        //        student.courses = new List<CourseModel>();
        //        foreach (var item in courses)
        //        {
        //            CourseModel model = new CourseModel();
        //            model.Assignments = new List<AssignmentModel>();
        //            model.CourseMarks = item.CourseMarks;
        //            model.CourseName = item.CourseName;

        //            foreach (var assignment in item.Assignments)
        //            {
        //                AssignmentModel assignmentModel = new AssignmentModel();
        //                assignmentModel.AssignmentName = assignment.AssignmentName;
        //                assignmentModel.Marks = assignment.Marks;
        //                model.Assignments.Add(assignment);
        //            }
        //            student.courses.Add(model);
        //        }
        //        Students.Add(student);
        //        MessageBox.Show("Added Successfully");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Student Already Exist.");
        //    }
        //}

        public List<Student> GetStudents(DataStore dataStore)
        {
            dataStore.Students = new List<Student>();

            foreach (var course in dataStore.Courses)
            {
                if (course.Students != null)
                {
                    foreach (var student in course?.Students)
                    {
                        if (dataStore.Students?.Any(x => x.Email == student.Email && x.StudentName == student.StudentName) == false)
                        {
                            dataStore.Students.Add(student);
                        }
                    }
                }
            }
            return dataStore.Students;
        }

        public void RemoveStudent(string name, string email, DataStore dataStore)
        {
            foreach (var course in dataStore.Courses)
            {
                if (dataStore.Students?.Any(x => x.Email == email && x.StudentName == name) == false)
                {
                    Student _student = new Student();
                    _student.StudentName = name;
                    var obj = course.Students.Where(x => x.StudentName == name).FirstOrDefault();
                    course.Students.Remove(obj);
                }

            }

        }

       
    }
}
