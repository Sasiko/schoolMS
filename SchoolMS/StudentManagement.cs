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
    public partial class StudentManagement : Form
    {
        ICourse course = new Course();
        IStudent student = new Student();
        public DataStore dataStore { get; set; }
        public StudentManagement(DataStore dataStore)
        {
            InitializeComponent();
            this.dataStore = dataStore;
            //lista över lagrade kurser i en checkbox lista  
            ((ListBox)lstCourses).DataSource = course.getCouses(dataStore);
            ((ListBox)lstCourses).DisplayMember = "CourseName";
            ((ListBox)lstCourses).ValueMember = "CourseName";
            updateGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Tilägg ny student
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            var courses = new List<Course>();
            foreach (var item in lstCourses.CheckedItems)
            {
                courses.Add((Course)item);
            }
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email)
                || courses.Count < 1)
            {
                MessageBox.Show("Please Enter the details.");
                return;
            }
            course.addStudent(name, phone, email, courses, dataStore);
            updateGrid();
        }
        void updateGrid()
        {
            dgStudents.AllowUserToAddRows = false;
            dgStudents.DataSource = new BindingSource(student.GetStudents(dataStore), "");
        }

        private void dgStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //Ta bort student med  en fönster prompt
                DialogResult dialogResult = MessageBox.Show("Delete Record?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    var Name = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var email = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    student.RemoveStudent(Name, email, dataStore);
                    updateGrid();
                    MessageBox.Show("Deleted Successfully..!");
                }
            }
        }
    }
}
