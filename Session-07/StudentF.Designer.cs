namespace Session_08
{
    partial class StudentF
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.grdCourses = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ctrlAge = new DevExpress.XtraEditors.SpinEdit();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlFullname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlRegNumber = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.bsCourses = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRegNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnNew);
            this.layoutControl1.Controls.Add(this.grdCourses);
            this.layoutControl1.Controls.Add(this.ctrlAge);
            this.layoutControl1.Controls.Add(this.ctrlName);
            this.layoutControl1.Controls.Add(this.ctrlSurname);
            this.layoutControl1.Controls.Add(this.ctrlFullname);
            this.layoutControl1.Controls.Add(this.ctrlRegNumber);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(607, 322);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(452, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(158, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 288);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(142, 22);
            this.btnNew.StyleController = this.layoutControl1;
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New...";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grdCourses
            // 
            this.grdCourses.Location = new System.Drawing.Point(12, 132);
            this.grdCourses.MainView = this.gridView1;
            this.grdCourses.Name = "grdCourses";
            this.grdCourses.Size = new System.Drawing.Size(583, 152);
            this.grdCourses.TabIndex = 9;
            this.grdCourses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colSubject});
            this.gridView1.GridControl = this.grdCourses;
            this.gridView1.Name = "gridView1";
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colSubject
            // 
            this.colSubject.Caption = "Subject";
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 1;
            // 
            // ctrlAge
            // 
            this.ctrlAge.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlAge.Location = new System.Drawing.Point(87, 108);
            this.ctrlAge.Name = "ctrlAge";
            this.ctrlAge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlAge.Size = new System.Drawing.Size(508, 20);
            this.ctrlAge.StyleController = this.layoutControl1;
            this.ctrlAge.TabIndex = 8;
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(87, 12);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Properties.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(508, 20);
            this.ctrlName.StyleController = this.layoutControl1;
            this.ctrlName.TabIndex = 4;
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(87, 36);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(508, 20);
            this.ctrlSurname.StyleController = this.layoutControl1;
            this.ctrlSurname.TabIndex = 5;
            // 
            // ctrlFullname
            // 
            this.ctrlFullname.Location = new System.Drawing.Point(87, 60);
            this.ctrlFullname.Name = "ctrlFullname";
            this.ctrlFullname.Size = new System.Drawing.Size(508, 20);
            this.ctrlFullname.StyleController = this.layoutControl1;
            this.ctrlFullname.TabIndex = 6;
            // 
            // ctrlRegNumber
            // 
            this.ctrlRegNumber.Location = new System.Drawing.Point(87, 84);
            this.ctrlRegNumber.Name = "ctrlRegNumber";
            this.ctrlRegNumber.Size = new System.Drawing.Size(508, 20);
            this.ctrlRegNumber.StyleController = this.layoutControl1;
            this.ctrlRegNumber.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(607, 322);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ctrlName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(587, 24);
            this.layoutControlItem1.Text = "Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ctrlSurname;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(587, 24);
            this.layoutControlItem2.Text = "Surname";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ctrlFullname;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(587, 24);
            this.layoutControlItem3.Text = "Full Name";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ctrlRegNumber;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(587, 24);
            this.layoutControlItem4.Text = "Reg. Number";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ctrlAge;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(587, 24);
            this.layoutControlItem5.Text = "Age";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.grdCourses;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(587, 156);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnNew;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 276);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(146, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnDelete;
            this.layoutControlItem8.Location = new System.Drawing.Point(146, 276);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(147, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnSave;
            this.layoutControlItem9.Location = new System.Drawing.Point(293, 276);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(147, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnCancel;
            this.layoutControlItem10.Location = new System.Drawing.Point(440, 276);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(147, 26);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // bsStudents
            // 
            this.bsStudents.CurrentChanged += new System.EventHandler(this.bsStudents_CurrentChanged);
            // 
            // StudentF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 322);
            this.Controls.Add(this.layoutControl1);
            this.Name = "StudentF";
            this.Text = "StudentF";
            this.Load += new System.EventHandler(this.StudentF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRegNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl grdCourses;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraEditors.SpinEdit ctrlAge;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlFullname;
        private DevExpress.XtraEditors.TextEdit ctrlRegNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private BindingSource bsStudents;
        private BindingSource bsCourses;
    }
}