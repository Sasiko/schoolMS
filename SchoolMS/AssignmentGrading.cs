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
    public partial class AssignmentGrading : Form
    {
        //Initialisera helper klass objekt inuti mallen "Helper"  
        ICourse course = new Course();
        IStudent student = new Student();
        IAssignment assignment = new Assignment();
        //List to store assignment data
        public List<AssignmentData> Assignments = new List<AssignmentData>();
        public DataStore dataStore { get; set; }
        public AssignmentGrading(DataStore dataStore)
        {
            InitializeComponent();
            this.dataStore = dataStore;
            //tilldela data i grid med student och labb uppgift 
            var data = course.getCouses(dataStore);//course.getCousesWithAssignments();

            foreach (var course in data)
            {
                if (course.Students != null)
                {
                    foreach (var student in course.Students)
                    {
                        if (course.Assignments != null)
                        {
                            foreach (var assignement in course.Assignments)
                            {
                                AssignmentData assignment = new AssignmentData();
                                assignment.AssignmentName = assignement.AssignmentName;
                                assignment.Marks = assignement.Marks;
                                assignment.CourseName = course.CourseName;
                                assignment.StudentName = student.StudentName;
                                assignment.CourseMarks = course.CourseMarks;

                                Assignments.Add(assignment);
                            }
                        }
                    }
                }
            }
            if (Assignments.Count == 0)
                MessageBox.Show("No Assignments Available");
            //foreach (var item in data)
            //{
            //    foreach (var item1 in item.Assignments)
            //    {
            //        AssignmentData assignment = new AssignmentData();
            //        assignment.AssignmentName = item1.AssignmentName;
            //        assignment.Marks = item1.Marks;
            //        assignment.CourseName = item.CourseName;

            //        Assignments.Add(assignment);
            //    }

            //}

            dgAssignments.DataSource = Assignments;
        }

        private void dgAssignments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Uppdatera student kurs och labb betyg 
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var courseName = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                var StudentName = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();                
                var AssignmentName = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                var AssignmentMarks = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                var CourseMarks = senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                assignment.UpdateGrade(courseName, StudentName, AssignmentName, AssignmentMarks, CourseMarks, dataStore);
            }
        }
    }
    //Helper classvisas i grid
    public class AssignmentData
    {
        public string CourseName { get; set; }
        public string StudentName { get; set; }
        public string AssignmentName { get; set; }
        public string Marks { get; set; }
        public string CourseMarks { get; set; }
    }
}
