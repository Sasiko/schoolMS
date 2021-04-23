using SchoolMS.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS.Helper
{
    public class Course : ICourse
    {
        private string courseMarks = "0";
        public string CourseName { get; set; }
        public Course(string CourseName)
        {
            this.CourseName = CourseName;
        }
        public Course()
        {
        }
        public string CourseMarks
        {
            get { return courseMarks; }
            set { courseMarks = value; }
        }
        public List<Assignment> Assignments { get; set; }
        public List<Student> Students { get; set; }
        ////Initialisera listan till lagrade kurser  
        //public static List<CourseModel> Courses = new List<CourseModel>();

        //Tillägg ny kurs
        public void AddCourse(string CourseName, DataStore dataStore)
        {
            if (!string.IsNullOrEmpty(CourseName))
            {
                var obj = dataStore.Courses?.Any(x => x.CourseName == CourseName);
                if (obj == false)
                {
                    Course course = new Course(CourseName);
                    dataStore.Courses.Add(course);
                }
                else
                {
                    MessageBox.Show("Couse Already Exist.");
                }

            }
            else
            {
                MessageBox.Show("Please Enter Course Name.");
            }
        }

        public List<Course> getCouses(DataStore dataStore)
        {
            return dataStore.Courses;
        }

        public List<Course> getCousesWithAssignments(DataStore dataStore)
        {
            return dataStore.Courses?.Where(x=>x.Assignments != null)?.ToList();
        }

        //Ta bort kurs
        public void RemoveCourse(string CourseName, DataStore dataStore)
        {
            Course course = new Course(CourseName);
            var obj = dataStore.Courses.Where(x => x.CourseName == CourseName).FirstOrDefault();
            dataStore.Courses.Remove(obj);
        }

        //public void UpdateGrade(string courseName, string AssignmentName, string marks)
        //{
        //    foreach (var item in Courses)
        //    {
        //        if(item.CourseName == courseName)
        //        {
        //            foreach (var assignemnt in item.Assignments)
        //            {
        //                if (assignemnt.AssignmentName == AssignmentName)
        //                {
        //                    assignemnt.Marks = marks;
        //                    MessageBox.Show("Marks Updated..!");
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //}

        public void addStudent(string name, string phone, string email, List<Course> _courses, DataStore dataStore)
        {
            foreach (var course in dataStore.Courses)
            {
                foreach (var _course in _courses)
                {
                    if (course.CourseName == _course.CourseName)
                    {
                        if (course.Students == null)
                            course.Students = new List<Student>();
                        var obj = course.Students?.Any(x => x.StudentName == name);
                        if (obj == false)
                        {
                            Student student = new Student();
                            student.StudentName = name;
                            student.Phone = phone;
                            student.Email = email;
                            course.Students.Add(student);
                            MessageBox.Show("Added Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Student Already Exist in {0}.", course.CourseName);
                        }
                    }

                }
            }

        }

        //Tillägg ny dator
        public void AddTeacher(string name, string phone, string email, string course, DataStore dataStore)
        {
            var obj = dataStore.Teachers?.Any(x => x.TeacherName == name);
            if (obj == false)
            {
                Teacher teacher = new Teacher();
                teacher.TeacherName = name;
                teacher.Phone = phone;
                teacher.Email = email;
                if (teacher.courses == null)
                    teacher.courses = new List<Course>();
                teacher.courses.Add(new Course(course));
                dataStore.Teachers.Add(teacher);
                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("Teacher Already Exist.");
            }
        }

        //Tilldela labb till kurs 
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
    }
}
