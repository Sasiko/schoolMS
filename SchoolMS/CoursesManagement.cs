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
    public partial class CoursesManagement : Form
    {
        ICourse course = new Course();
        public DataStore dataStore { get; set; }
        public CoursesManagement(DataStore dataStore)
        {
            InitializeComponent();
            this.dataStore = dataStore;
            //Uppdatera kurs i grid  
            updateGrid();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //Tilägg ny kurs
            course.AddCourse(tbCourse.Text,dataStore);
            updateGrid();            
            tbCourse.Text = string.Empty;
        }

        public void updateGrid()
        {
            //dgCouses.DataSource = null;
            dgCouses.DataSource = new BindingSource(course.getCouses(dataStore), ""); 
            dgCouses.Columns[0].Width = 200;
            dgCouses.Columns[1].Width = 400;
        }

        private void dgCouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //Ta bort kurs
                DialogResult dialogResult = MessageBox.Show("Delete Record?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    var Name = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    course.RemoveCourse(Name, dataStore);
                    updateGrid();
                    MessageBox.Show("Deleted Successfully..!");                    
                }
            }
        }

        private void btnAddAssignments_Click(object sender, EventArgs e)
        {
            //Öppna fönster för labb
            AssignmentManagement assignment = new AssignmentManagement(dataStore);
            assignment.Show();
        }
    }
}
