namespace SchoolMS
{
    partial class ViewTeacherInfo
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
            this.dgTeachers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentsCounr = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTeachers
            // 
            this.dgTeachers.AllowUserToAddRows = false;
            this.dgTeachers.AllowUserToResizeColumns = false;
            this.dgTeachers.AllowUserToResizeRows = false;
            this.dgTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.StudentName,
            this.ClassCount});
            this.dgTeachers.Location = new System.Drawing.Point(42, 91);
            this.dgTeachers.Name = "dgTeachers";
            this.dgTeachers.Size = new System.Drawing.Size(743, 293);
            this.dgTeachers.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total Students = ";
            // 
            // lblStudentsCounr
            // 
            this.lblStudentsCounr.AutoSize = true;
            this.lblStudentsCounr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentsCounr.Location = new System.Drawing.Point(728, 44);
            this.lblStudentsCounr.Name = "lblStudentsCounr";
            this.lblStudentsCounr.Size = new System.Drawing.Size(0, 20);
            this.lblStudentsCounr.TabIndex = 14;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "CourseName";
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.Width = 250;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Enrolled Students";
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 250;
            // 
            // ClassCount
            // 
            this.ClassCount.DataPropertyName = "ClassCount";
            this.ClassCount.HeaderText = "ClassCount";
            this.ClassCount.Name = "ClassCount";
            this.ClassCount.Width = 200;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.Location = new System.Drawing.Point(187, 44);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(0, 20);
            this.lblTeacherName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Teacher Name : ";
            // 
            // ViewTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(832, 431);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStudentsCounr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTeachers);
            this.Name = "ViewTeacherInfo";
            this.Text = "ViewTeacherInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dgTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTeachers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentsCounr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassCount;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label label3;
    }
}