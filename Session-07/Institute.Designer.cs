namespace Session_07
{
    partial class Institute
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
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.universityItem = new DevExpress.XtraBars.BarSubItem();
            this.universityEdit = new DevExpress.XtraBars.BarButtonItem();
            this.universitySave = new DevExpress.XtraBars.BarButtonItem();
            this.universityLoad = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.professorEdit = new DevExpress.XtraBars.BarButtonItem();
            this.professorSave = new DevExpress.XtraBars.BarButtonItem();
            this.professorLoad = new DevExpress.XtraBars.BarButtonItem();
            this.studentItem = new DevExpress.XtraBars.BarSubItem();
            this.studentEdit = new DevExpress.XtraBars.BarButtonItem();
            this.studentSave = new DevExpress.XtraBars.BarButtonItem();
            this.studentLoad = new DevExpress.XtraBars.BarButtonItem();
            this.courseItem = new DevExpress.XtraBars.BarSubItem();
            this.courseEdit = new DevExpress.XtraBars.BarButtonItem();
            this.courseSave = new DevExpress.XtraBars.BarButtonItem();
            this.courseLoad = new DevExpress.XtraBars.BarButtonItem();
            this.Save = new DevExpress.XtraBars.BarSubItem();
            this.scheduleEdit = new DevExpress.XtraBars.BarButtonItem();
            this.scheduleSave = new DevExpress.XtraBars.BarButtonItem();
            this.scheduleLoad = new DevExpress.XtraBars.BarButtonItem();
            this.gradeItem = new DevExpress.XtraBars.BarSubItem();
            this.gradeEdit = new DevExpress.XtraBars.BarButtonItem();
            this.gradeSave = new DevExpress.XtraBars.BarButtonItem();
            this.gradeLoad = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl.Location = new System.Drawing.Point(0, 20);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(852, 624, 650, 400);
            this.dataLayoutControl.Root = this.Root;
            this.dataLayoutControl.Size = new System.Drawing.Size(800, 410);
            this.dataLayoutControl.TabIndex = 0;
            this.dataLayoutControl.Text = "dataLayoutControl";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 410);
            this.Root.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.universityItem,
            this.barSubItem2,
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.universitySave,
            this.universityLoad,
            this.professorSave,
            this.professorLoad,
            this.studentItem,
            this.courseItem,
            this.Save,
            this.studentSave,
            this.studentLoad,
            this.courseSave,
            this.courseLoad,
            this.scheduleSave,
            this.scheduleLoad,
            this.universityEdit,
            this.professorEdit,
            this.studentEdit,
            this.courseEdit,
            this.barButtonItem6,
            this.barSubItem3,
            this.gradeItem,
            this.gradeEdit,
            this.gradeSave,
            this.gradeLoad,
            this.scheduleEdit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 36;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.universityItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.studentItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.courseItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.gradeItem)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // universityItem
            // 
            this.universityItem.Caption = "University";
            this.universityItem.Id = 0;
            this.universityItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.universityEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.universitySave),
            new DevExpress.XtraBars.LinkPersistInfo(this.universityLoad)});
            this.universityItem.Name = "universityItem";
            // 
            // universityEdit
            // 
            this.universityEdit.Caption = "Edit";
            this.universityEdit.Id = 24;
            this.universityEdit.Name = "universityEdit";
            this.universityEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.universityEdit_ItemClick);
            // 
            // universitySave
            // 
            this.universitySave.Caption = "Save";
            this.universitySave.Id = 8;
            this.universitySave.Name = "universitySave";
            this.universitySave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.universitySave_ItemClick);
            // 
            // universityLoad
            // 
            this.universityLoad.Caption = "Load";
            this.universityLoad.Id = 9;
            this.universityLoad.Name = "universityLoad";
            this.universityLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.universityLoad_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Professor";
            this.barSubItem2.Id = 1;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.professorEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.professorSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.professorLoad)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // professorEdit
            // 
            this.professorEdit.Caption = "Edit";
            this.professorEdit.Id = 25;
            this.professorEdit.Name = "professorEdit";
            this.professorEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.professorEdit_ItemClick);
            // 
            // professorSave
            // 
            this.professorSave.Caption = "Save";
            this.professorSave.Id = 10;
            this.professorSave.Name = "professorSave";
            this.professorSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.professorSave_ItemClick);
            // 
            // professorLoad
            // 
            this.professorLoad.Caption = "Load";
            this.professorLoad.Id = 11;
            this.professorLoad.Name = "professorLoad";
            this.professorLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.professorLoad_ItemClick);
            // 
            // studentItem
            // 
            this.studentItem.Caption = "Student";
            this.studentItem.Id = 12;
            this.studentItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.studentEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.studentSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.studentLoad)});
            this.studentItem.Name = "studentItem";
            // 
            // studentEdit
            // 
            this.studentEdit.Caption = "Edit";
            this.studentEdit.Id = 26;
            this.studentEdit.Name = "studentEdit";
            this.studentEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.studentEdit_ItemClick);
            // 
            // studentSave
            // 
            this.studentSave.Caption = "Save";
            this.studentSave.Id = 16;
            this.studentSave.Name = "studentSave";
            this.studentSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.studentSave_ItemClick);
            // 
            // studentLoad
            // 
            this.studentLoad.Caption = "Load";
            this.studentLoad.Id = 17;
            this.studentLoad.Name = "studentLoad";
            this.studentLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.studentLoad_ItemClick);
            // 
            // courseItem
            // 
            this.courseItem.Caption = "Course";
            this.courseItem.Id = 13;
            this.courseItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.courseEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.courseSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.courseLoad)});
            this.courseItem.Name = "courseItem";
            // 
            // courseEdit
            // 
            this.courseEdit.Caption = "Edit";
            this.courseEdit.Id = 27;
            this.courseEdit.Name = "courseEdit";
            this.courseEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.courseEdit_ItemClick);
            // 
            // courseSave
            // 
            this.courseSave.Caption = "Save";
            this.courseSave.Id = 18;
            this.courseSave.Name = "courseSave";
            this.courseSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.courseSave_ItemClick);
            // 
            // courseLoad
            // 
            this.courseLoad.Caption = "Load";
            this.courseLoad.Id = 19;
            this.courseLoad.Name = "courseLoad";
            this.courseLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.courseLoad_ItemClick);
            // 
            // Save
            // 
            this.Save.Caption = "Schedule";
            this.Save.Id = 14;
            this.Save.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.scheduleEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.scheduleSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.scheduleLoad)});
            this.Save.Name = "Save";
            // 
            // scheduleEdit
            // 
            this.scheduleEdit.Caption = "Edit";
            this.scheduleEdit.Id = 35;
            this.scheduleEdit.Name = "scheduleEdit";
            this.scheduleEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.scheduleEdit_ItemClick);
            // 
            // scheduleSave
            // 
            this.scheduleSave.Caption = "Save";
            this.scheduleSave.Id = 20;
            this.scheduleSave.Name = "scheduleSave";
            this.scheduleSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.scheduleSave_ItemClick);
            // 
            // scheduleLoad
            // 
            this.scheduleLoad.Caption = "Load";
            this.scheduleLoad.Id = 21;
            this.scheduleLoad.Name = "scheduleLoad";
            this.scheduleLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.scheduleLoad_ItemClick);
            // 
            // gradeItem
            // 
            this.gradeItem.Caption = "Grade";
            this.gradeItem.Id = 31;
            this.gradeItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.gradeEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.gradeSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.gradeLoad)});
            this.gradeItem.Name = "gradeItem";
            // 
            // gradeEdit
            // 
            this.gradeEdit.Caption = "Edit";
            this.gradeEdit.Id = 32;
            this.gradeEdit.Name = "gradeEdit";
            this.gradeEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.gradeEdit_ItemClick);
            // 
            // gradeSave
            // 
            this.gradeSave.Caption = "Save";
            this.gradeSave.Id = 33;
            this.gradeSave.Name = "gradeSave";
            this.gradeSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.gradeSave_ItemClick);
            // 
            // gradeLoad
            // 
            this.gradeLoad.Caption = "Load";
            this.gradeLoad.Id = 34;
            this.gradeLoad.Name = "gradeLoad";
            this.gradeLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.gradeLoad_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 410);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 410);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Load";
            this.barSubItem1.Id = 3;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Save";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Load";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 29;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Grade";
            this.barSubItem3.Id = 30;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // Institute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLayoutControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Institute";
            this.Text = "Institute";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem universityItem;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem universitySave;
        private DevExpress.XtraBars.BarButtonItem universityLoad;
        private DevExpress.XtraBars.BarButtonItem professorSave;
        private DevExpress.XtraBars.BarButtonItem professorLoad;
        private DevExpress.XtraBars.BarSubItem studentItem;
        private DevExpress.XtraBars.BarSubItem courseItem;
        private DevExpress.XtraBars.BarSubItem Save;
        private DevExpress.XtraBars.BarButtonItem studentSave;
        private DevExpress.XtraBars.BarButtonItem studentLoad;
        private DevExpress.XtraBars.BarButtonItem courseSave;
        private DevExpress.XtraBars.BarButtonItem courseLoad;
        private DevExpress.XtraBars.BarButtonItem scheduleSave;
        private DevExpress.XtraBars.BarButtonItem scheduleLoad;
        private DevExpress.XtraBars.BarButtonItem universityEdit;
        private DevExpress.XtraBars.BarButtonItem professorEdit;
        private DevExpress.XtraBars.BarButtonItem studentEdit;
        private DevExpress.XtraBars.BarButtonItem courseEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem gradeItem;
        private DevExpress.XtraBars.BarButtonItem gradeEdit;
        private DevExpress.XtraBars.BarButtonItem gradeSave;
        private DevExpress.XtraBars.BarButtonItem gradeLoad;
        private DevExpress.XtraBars.BarButtonItem scheduleEdit;
    }
}

