using SchoolMS.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS.Helper
{
    public class Teacher : ITeacher
    {
        public string TeacherName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Course> courses { get; set; }

        //public static List<TeacherModel> Teachers = new List<TeacherModel>();

        //public void AddTeacher(string name, string phone, string email, string course)
        //{
        //    var obj = Teachers?.Any(x => x.TeacherName == name);
        //    if (obj == false)
        //    {
        //        TeacherModel teacher = new TeacherModel();
        //        teacher.TeacherName = name;
        //        teacher.Phone = phone;
        //        teacher.Email = email;
        //        if (teacher.courses == null)
        //            teacher.courses = new List<CourseModel>();
        //        teacher.courses.Add(new CourseModel(course));
        //        Teachers.Add(teacher);
        //        MessageBox.Show("Added Successfully");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Teacher Already Exist.");
        //    }
        //}

        public List<Student> getCourseStudents(string courseName, DataStore dataStore)
        {
            var course = dataStore.Courses?.Where(x => x.CourseName == courseName)?.FirstOrDefault();
            return course.Students;
        }

        public List<Teacher> getTeachers(DataStore dataStore)
        {
            return dataStore.Teachers;
        }

        //ta bort lärare
        public void RemoveTeacher(string name, DataStore dataStore)
        {
            Teacher teacher = new Teacher();
            teacher.TeacherName = name;
            var obj = dataStore.Teachers.Where(x => x.TeacherName == name).FirstOrDefault();
            dataStore.Teachers.Remove(obj);
        }
    }
}
