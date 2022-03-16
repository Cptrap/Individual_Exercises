namespace Session_08
{
    partial class XtraForm1
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.universityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUniversity = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUniversity = new System.Windows.Forms.ToolStripMenuItem();
            this.loadUniversity = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGrade = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 24);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(607, 298);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(607, 298);
            this.Root.TextVisible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.universityToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.gradeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // universityToolStripMenuItem
            // 
            this.universityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUniversity,
            this.saveUniversity,
            this.loadUniversity});
            this.universityToolStripMenuItem.Name = "universityToolStripMenuItem";
            this.universityToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.universityToolStripMenuItem.Text = "University";
            // 
            // editUniversity
            // 
            this.editUniversity.Name = "editUniversity";
            this.editUniversity.Size = new System.Drawing.Size(103, 22);
            this.editUniversity.Text = "Edit...";
            this.editUniversity.Click += new System.EventHandler(this.editUniversity_Click);
            // 
            // saveUniversity
            // 
            this.saveUniversity.Name = "saveUniversity";
            this.saveUniversity.Size = new System.Drawing.Size(103, 22);
            this.saveUniversity.Text = "Save";
            this.saveUniversity.Click += new System.EventHandler(this.saveUniversity_Click);
            // 
            // loadUniversity
            // 
            this.loadUniversity.Name = "loadUniversity";
            this.loadUniversity.Size = new System.Drawing.Size(103, 22);
            this.loadUniversity.Text = "Load";
            this.loadUniversity.Click += new System.EventHandler(this.loadUniversity_Click);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfessor,
            this.saveProfessor,
            this.loadProfessor});
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.professorToolStripMenuItem.Text = "Professor";
            // 
            // editProfessor
            // 
            this.editProfessor.Name = "editProfessor";
            this.editProfessor.Size = new System.Drawing.Size(100, 22);
            this.editProfessor.Text = "Edit..";
            this.editProfessor.Click += new System.EventHandler(this.editProfessor_Click);
            // 
            // saveProfessor
            // 
            this.saveProfessor.Name = "saveProfessor";
            this.saveProfessor.Size = new System.Drawing.Size(100, 22);
            this.saveProfessor.Text = "Save";
            this.saveProfessor.Click += new System.EventHandler(this.saveProfessor_Click);
            // 
            // loadProfessor
            // 
            this.loadProfessor.Name = "loadProfessor";
            this.loadProfessor.Size = new System.Drawing.Size(100, 22);
            this.loadProfessor.Text = "Load";
            this.loadProfessor.Click += new System.EventHandler(this.loadProfessor_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editStudent,
            this.saveStudent,
            this.loadStudent});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // editStudent
            // 
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(100, 22);
            this.editStudent.Text = "Edit..";
            this.editStudent.Click += new System.EventHandler(this.editStudent_Click);
            // 
            // saveStudent
            // 
            this.saveStudent.Name = "saveStudent";
            this.saveStudent.Size = new System.Drawing.Size(100, 22);
            this.saveStudent.Text = "Save";
            this.saveStudent.Click += new System.EventHandler(this.saveStudent_Click);
            // 
            // loadStudent
            // 
            this.loadStudent.Name = "loadStudent";
            this.loadStudent.Size = new System.Drawing.Size(100, 22);
            this.loadStudent.Text = "Load";
            this.loadStudent.Click += new System.EventHandler(this.loadStudent_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCourse,
            this.saveCourse,
            this.loadCourse});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // editCourse
            // 
            this.editCourse.Name = "editCourse";
            this.editCourse.Size = new System.Drawing.Size(100, 22);
            this.editCourse.Text = "Edit..";
            this.editCourse.Click += new System.EventHandler(this.editCourse_Click);
            // 
            // saveCourse
            // 
            this.saveCourse.Name = "saveCourse";
            this.saveCourse.Size = new System.Drawing.Size(100, 22);
            this.saveCourse.Text = "Save";
            this.saveCourse.Click += new System.EventHandler(this.saveCourse_Click);
            // 
            // loadCourse
            // 
            this.loadCourse.Name = "loadCourse";
            this.loadCourse.Size = new System.Drawing.Size(100, 22);
            this.loadCourse.Text = "Load";
            this.loadCourse.Click += new System.EventHandler(this.loadCourse_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSchedule,
            this.saveSchedule,
            this.loadSchedule});
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            // 
            // editSchedule
            // 
            this.editSchedule.Name = "editSchedule";
            this.editSchedule.Size = new System.Drawing.Size(100, 22);
            this.editSchedule.Text = "Edit..";
            this.editSchedule.Click += new System.EventHandler(this.editSchedule_Click);
            // 
            // saveSchedule
            // 
            this.saveSchedule.Name = "saveSchedule";
            this.saveSchedule.Size = new System.Drawing.Size(100, 22);
            this.saveSchedule.Text = "Save";
            this.saveSchedule.Click += new System.EventHandler(this.saveSchedule_Click);
            // 
            // loadSchedule
            // 
            this.loadSchedule.Name = "loadSchedule";
            this.loadSchedule.Size = new System.Drawing.Size(100, 22);
            this.loadSchedule.Text = "Load";
            this.loadSchedule.Click += new System.EventHandler(this.loadSchedule_Click);
            // 
            // gradeToolStripMenuItem
            // 
            this.gradeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGrade,
            this.saveGrade,
            this.loadGrade});
            this.gradeToolStripMenuItem.Name = "gradeToolStripMenuItem";
            this.gradeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gradeToolStripMenuItem.Text = "Grade";
            // 
            // editGrade
            // 
            this.editGrade.Name = "editGrade";
            this.editGrade.Size = new System.Drawing.Size(100, 22);
            this.editGrade.Text = "Edit..";
            this.editGrade.Click += new System.EventHandler(this.editGrade_Click);
            // 
            // saveGrade
            // 
            this.saveGrade.Name = "saveGrade";
            this.saveGrade.Size = new System.Drawing.Size(100, 22);
            this.saveGrade.Text = "Save";
            this.saveGrade.Click += new System.EventHandler(this.saveGrade_Click);
            // 
            // loadGrade
            // 
            this.loadGrade.Name = "loadGrade";
            this.loadGrade.Size = new System.Drawing.Size(100, 22);
            this.loadGrade.Text = "Load";
            this.loadGrade.Click += new System.EventHandler(this.loadGrade_Click);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 322);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XtraForm1_FormClosed);
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem universityToolStripMenuItem;
        private ToolStripMenuItem editUniversity;
        private ToolStripMenuItem saveUniversity;
        private ToolStripMenuItem loadUniversity;
        private ToolStripMenuItem professorToolStripMenuItem;
        private ToolStripMenuItem editProfessor;
        private ToolStripMenuItem saveProfessor;
        private ToolStripMenuItem loadProfessor;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem editStudent;
        private ToolStripMenuItem saveStudent;
        private ToolStripMenuItem loadStudent;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem editCourse;
        private ToolStripMenuItem saveCourse;
        private ToolStripMenuItem loadCourse;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem editSchedule;
        private ToolStripMenuItem saveSchedule;
        private ToolStripMenuItem loadSchedule;
        private ToolStripMenuItem gradeToolStripMenuItem;
        private ToolStripMenuItem editGrade;
        private ToolStripMenuItem saveGrade;
        private ToolStripMenuItem loadGrade;
    }
}