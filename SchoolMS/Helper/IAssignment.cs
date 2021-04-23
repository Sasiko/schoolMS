using SchoolMS.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Helper
{
    interface IAssignment
    {
        void AddAssignment(string name, string courseName, DataStore dataStore);
        void UpdateGrade(string courseName, string StudentName, string AssignmentName, string AssignmentMarks, string CourseMarks, DataStore dataStore);
    }
}
