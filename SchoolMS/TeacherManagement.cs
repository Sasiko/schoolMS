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
    public partial class TeacherManagement : Form
    {
        ITeacher teacher = new Teacher();
        ICourse course = new Course();
        public DataStore dataStore { get; set; }
        public TeacherManagement(DataStore dataStore)
        {
            InitializeComponent();
            this.dataStore = dataStore;
            //Uppdatera lärarlag infon
            updateGrid();

            //tilldela datakälla till kurs dropdown  
            cmbCourses.DataSource = course.getCouses(dataStore);
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseName";
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            //tilägg ny lärare
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            string _course = cmbCourses.SelectedValue.ToString();
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please Enter the details.");
                return;
            }
            course.AddTeacher(name, phone, email, _course, dataStore);
            //Uppdatera lärarlag datan efter tillägg av ny lärare
            updateGrid();
        }

        private void dgTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Delete Record?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    var Name = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    teacher.RemoveTeacher(Name, dataStore);
                    updateGrid();
                    MessageBox.Show("Deleted Successfully..!");
                }
            }
        }

        void updateGrid()
        {
            dgTeachers.AllowUserToAddRows = false;
            dgTeachers.DataSource = new BindingSource(teacher.getTeachers(dataStore), "");
        }

        private void dgTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn && e.RowIndex >= 0)
            {
                var tchrName = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                var tch = teacher.getTeachers(dataStore)?.Where(x => x.TeacherName == tchrName)?.FirstOrDefault();
                ViewTeacherInfo teacherInfo = new ViewTeacherInfo(tch, dataStore);
                teacherInfo.ShowDialog();
            }
        }
    }
}
