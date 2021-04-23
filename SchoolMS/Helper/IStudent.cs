using SchoolMS.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Helper
{
    // interface för student implementation
    interface IStudent
    {
        //void addStudent(string name, string phone, string email, List<CourseModel> courses);
        void RemoveStudent(string name, string email, DataStore dataStore);
        List<Student> GetStudents(DataStore dataStore);
        
    }
}
