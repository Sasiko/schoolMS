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
    public partial class AssignmentManagement : Form
    {
        ICourse course = new Course();
        IAssignment assignment = new Assignment();
        public DataStore dataStore { get; set; }
        public AssignmentManagement(DataStore dataStore)
        {
            InitializeComponent();
            this.dataStore = dataStore;
            //Tilldela data källa till kurs drop down 
            cmbCourses.DataSource = course.getCouses(dataStore);
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //tillägg ny data
            string name = tbName.Text;
            string courseName = cmbCourses.SelectedValue.ToString();
            assignment.AddAssignment(name,courseName, dataStore);
        }
    }
}
