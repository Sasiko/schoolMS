using SchoolMS.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.AppData
{
    public class DataStore
    {
        // Lista över lagrade kurser
        public List<Course> Courses { get; set; }
        // Lista över lagrade lärarlag
        public List<Teacher> Teachers { get; set; }
        // Lista över lagrade studenter
        public List<Student> Students { get; set; }
        public DataStore()
        {
            Courses = new List<Course>();
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }
    }
}

