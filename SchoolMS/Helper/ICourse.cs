using SchoolMS.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Helper
{
    //Interface för kurs 
    interface ICourse
    {

        void AddCourse(string CourseName, DataStore dataStore);
        void RemoveCourse(string CourseName, DataStore dataStore);
        void AddAssignment(string name, string courseName, DataStore dataStore);
        List<Course> getCouses(DataStore dataStore);
        List<Course> getCousesWithAssignments(DataStore dataStore);
        //void UpdateGrade(string courseName, string AssignmentName,string marks);
        void addStudent(string name, string phone, string email, List<Course> courses, DataStore dataStore);
        void AddTeacher(string name, string phone, string email, string course, DataStore dataStore);
    }
}
