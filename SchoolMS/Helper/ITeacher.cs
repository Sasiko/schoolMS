using SchoolMS.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Helper
{
    // interface for Teacher implementation
    interface ITeacher
    {
        //void AddTeacher(string name, string phone, string email, string course);
        void RemoveTeacher(string name, DataStore dataStore);
        List<Teacher> getTeachers(DataStore dataStore);
        List<Student> getCourseStudents(string courseName, DataStore dataStore);
    }
}
