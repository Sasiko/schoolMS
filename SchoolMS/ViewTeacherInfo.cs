using SchoolMS.AppData;
using SchoolMS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS
{
    public partial class ViewTeacherInfo : Form
    {
        public List<TeacherInfo> Teachers = new List<TeacherInfo>();
        public DataStore dataStore { get; set; }
        ITeacher teacher = new Teacher();
        public ViewTeacherInfo(Teacher tch, DataStore dataStore)
        {
            InitializeComponent();
            this.dataStore = dataStore;
            loadGrid(tch);
        }

        void loadGrid(Teacher tch)
        {
            int count = 0;
            if(tch != null)
            {
                lblTeacherName.Text = tch.TeacherName;

                if(tch.courses != null && tch.courses.Count > 0)
                {
                    foreach (var course in tch.courses)
                    {
                        var _students = teacher.getCourseStudents(course.CourseName, dataStore);
                        if(_students != null && _students.Count > 0)
                        {
                            foreach (var student in _students)
                            {
                                TeacherInfo info = new TeacherInfo();
                                info.ClassCount = _students.Count;
                                info.CourseName = course.CourseName;
                                info.StudentName = student.StudentName;

                                Teachers.Add(info);
                                count++;
                            }
                        }
                    }
                }
                dgTeachers.DataSource = Teachers;
                lblStudentsCounr.Text = count.ToString();
            }
        }
    }

    public class TeacherInfo
    {
        public string CourseName { get; set; }
        public string StudentName { get; set; }
        public int ClassCount { get; set; }
    }
}
