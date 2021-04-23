namespace SchoolMS
{
    partial class AssignmentGrading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgAssignments = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAssignments
            // 
            this.dgAssignments.AllowUserToAddRows = false;
            this.dgAssignments.AllowUserToDeleteRows = false;
            this.dgAssignments.AllowUserToResizeColumns = false;
            this.dgAssignments.AllowUserToResizeRows = false;
            this.dgAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.StudentName,
            this.AssignmentName,
            this.CourseName,
            this.Marks,
            this.CourseMarks});
            this.dgAssignments.Location = new System.Drawing.Point(15, 104);
            this.dgAssignments.Name = "dgAssignments";
            this.dgAssignments.Size = new System.Drawing.Size(745, 298);
            this.dgAssignments.TabIndex = 0;
            this.dgAssignments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAssignments_CellContentClick);
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.ToolTipText = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // AssignmentName
            // 
            this.AssignmentName.DataPropertyName = "AssignmentName";
            this.AssignmentName.HeaderText = "Assignment Name";
            this.AssignmentName.Name = "AssignmentName";
            this.AssignmentName.ReadOnly = true;
            this.AssignmentName.Width = 200;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Marks
            // 
            this.Marks.DataPropertyName = "Marks";
            this.Marks.HeaderText = "Marks";
            this.Marks.Name = "Marks";
            // 
            // CourseMarks
            // 
            this.CourseMarks.DataPropertyName = "CourseMarks";
            this.CourseMarks.HeaderText = "Course Grade";
            this.CourseMarks.Name = "CourseMarks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assignement Grading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(146, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please double click the grades field to update with new grades";
            // 
            // AssignmentGrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(781, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAssignments);
            this.Name = "AssignmentGrading";
            this.Text = "AssignmentGrading";
            ((System.ComponentModel.ISupportInitialize)(this.dgAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAssignments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseMarks;
        private System.Windows.Forms.Label label2;
    }
}