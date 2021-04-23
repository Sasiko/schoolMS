namespace SchoolMS
{
    partial class CoursesManagement
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
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.tbCourse = new System.Windows.Forms.TextBox();
            this.dgCouses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAssignments = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCouses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(577, 60);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(141, 31);
            this.btnAddCourse.TabIndex = 0;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // tbCourse
            // 
            this.tbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCourse.Location = new System.Drawing.Point(309, 60);
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(222, 26);
            this.tbCourse.TabIndex = 1;
            // 
            // dgCouses
            // 
            this.dgCouses.AllowUserToAddRows = false;
            this.dgCouses.AllowUserToResizeColumns = false;
            this.dgCouses.AllowUserToResizeRows = false;
            this.dgCouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.CourseName,
            this.CourseMarks});
            this.dgCouses.Location = new System.Drawing.Point(39, 145);
            this.dgCouses.Name = "dgCouses";
            this.dgCouses.Size = new System.Drawing.Size(746, 293);
            this.dgCouses.TabIndex = 2;
            this.dgCouses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCouses_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course Name";
            // 
            // btnAddAssignments
            // 
            this.btnAddAssignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAssignments.Location = new System.Drawing.Point(12, 12);
            this.btnAddAssignments.Name = "btnAddAssignments";
            this.btnAddAssignments.Size = new System.Drawing.Size(141, 31);
            this.btnAddAssignments.TabIndex = 4;
            this.btnAddAssignments.Text = "Assignments";
            this.btnAddAssignments.UseVisualStyleBackColor = true;
            this.btnAddAssignments.Click += new System.EventHandler(this.btnAddAssignments_Click);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 200;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 400;
            // 
            // CourseMarks
            // 
            this.CourseMarks.DataPropertyName = "CourseMarks";
            this.CourseMarks.HeaderText = "Course Marks";
            this.CourseMarks.Name = "CourseMarks";
            // 
            // CoursesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(819, 486);
            this.Controls.Add(this.btnAddAssignments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCouses);
            this.Controls.Add(this.tbCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Name = "CoursesManagement";
            this.Text = "CoursesManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgCouses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TextBox tbCourse;
        private System.Windows.Forms.DataGridView dgCouses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAssignments;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseMarks;
    }
}