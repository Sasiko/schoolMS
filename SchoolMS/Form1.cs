using SchoolMS.AppData;
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
    public partial class Form1 : Form
    {
        public DataStore dataStore;
        public Form1()
        {
            InitializeComponent();
            dataStore = new DataStore();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            CoursesManagement courses = new CoursesManagement(dataStore);
            courses.Show();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherManagement teacher = new TeacherManagement(dataStore);
            teacher.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentManagement student = new StudentManagement(dataStore);
            student.Show();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            AssignmentGrading grading = new AssignmentGrading(dataStore);
            grading.Show();
        }
    }
}
