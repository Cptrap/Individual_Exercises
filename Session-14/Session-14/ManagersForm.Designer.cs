namespace Session_14
{
    partial class ManagersForm
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
            this.layoutControlManagers = new DevExpress.XtraLayout.LayoutControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveClose = new DevExpress.XtraEditors.SimpleButton();
            this.grdManagers = new DevExpress.XtraGrid.GridControl();
            this.bsManagers = new System.Windows.Forms.BindingSource(this.components);
            this.grvManagers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSallary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.txtSallary = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlManagers)).BeginInit();
            this.layoutControlManagers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSallary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlManagers
            // 
            this.layoutControlManagers.Controls.Add(this.btnEdit);
            this.layoutControlManagers.Controls.Add(this.btnDelete);
            this.layoutControlManagers.Controls.Add(this.btnNew);
            this.layoutControlManagers.Controls.Add(this.btnSaveClose);
            this.layoutControlManagers.Controls.Add(this.grdManagers);
            this.layoutControlManagers.Controls.Add(this.txtName);
            this.layoutControlManagers.Controls.Add(this.txtSurname);
            this.layoutControlManagers.Controls.Add(this.txtSallary);
            this.layoutControlManagers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlManagers.Location = new System.Drawing.Point(0, 0);
            this.layoutControlManagers.Name = "layoutControlManagers";
            this.layoutControlManagers.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(764, 599, 650, 400);
            this.layoutControlManagers.Root = this.Root;
            this.layoutControlManagers.Size = new System.Drawing.Size(752, 437);
            this.layoutControlManagers.TabIndex = 0;
            this.layoutControlManagers.Text = "layoutControl1";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(391, 403);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(188, 22);
            this.btnEdit.StyleController = this.layoutControlManagers;
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 22);
            this.btnDelete.StyleController = this.layoutControlManagers;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 403);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(184, 22);
            this.btnNew.StyleController = this.layoutControlManagers;
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Add";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(583, 403);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(157, 22);
            this.btnSaveClose.StyleController = this.layoutControlManagers;
            this.btnSaveClose.TabIndex = 6;
            this.btnSaveClose.Text = "Close";
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // grdManagers
            // 
            this.grdManagers.DataSource = this.bsManagers;
            this.grdManagers.Location = new System.Drawing.Point(12, 84);
            this.grdManagers.MainView = this.grvManagers;
            this.grdManagers.Name = "grdManagers";
            this.grdManagers.Size = new System.Drawing.Size(728, 315);
            this.grdManagers.TabIndex = 2;
            this.grdManagers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvManagers});
            this.grdManagers.Click += new System.EventHandler(this.gridControlManagers_Click);
            // 
            // grvManagers
            // 
            this.grvManagers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColName,
            this.grdColSurname,
            this.gridColumnSallary});
            this.grvManagers.GridControl = this.grdManagers;
            this.grvManagers.Name = "grvManagers";
            // 
            // grdColName
            // 
            this.grdColName.Caption = "Name";
            this.grdColName.FieldName = "Name";
            this.grdColName.Name = "grdColName";
            this.grdColName.OptionsColumn.AllowEdit = false;
            this.grdColName.Visible = true;
            this.grdColName.VisibleIndex = 0;
            // 
            // grdColSurname
            // 
            this.grdColSurname.Caption = "Surname";
            this.grdColSurname.FieldName = "Surname";
            this.grdColSurname.Name = "grdColSurname";
            this.grdColSurname.OptionsColumn.AllowEdit = false;
            this.grdColSurname.Visible = true;
            this.grdColSurname.VisibleIndex = 1;
            // 
            // gridColumnSallary
            // 
            this.gridColumnSallary.Caption = "Sallary Per Month";
            this.gridColumnSallary.FieldName = "SallaryPerMonth";
            this.gridColumnSallary.Name = "gridColumnSallary";
            this.gridColumnSallary.OptionsColumn.AllowEdit = false;
            this.gridColumnSallary.Visible = true;
            this.gridColumnSallary.VisibleIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 20);
            this.txtName.StyleController = this.layoutControlManagers;
            this.txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(66, 36);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(170, 20);
            this.txtSurname.StyleController = this.layoutControlManagers;
            this.txtSurname.TabIndex = 7;
            // 
            // txtSallary
            // 
            this.txtSallary.Location = new System.Drawing.Point(66, 60);
            this.txtSallary.Name = "txtSallary";
            this.txtSallary.Size = new System.Drawing.Size(95, 20);
            this.txtSallary.StyleController = this.layoutControlManagers;
            this.txtSallary.TabIndex = 8;
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
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(752, 437);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdManagers;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(732, 319);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSaveClose;
            this.layoutControlItem2.Location = new System.Drawing.Point(571, 391);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnNew;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 391);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(188, 391);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(191, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(379, 391);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(192, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtName;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(181, 24);
            this.layoutControlItem6.Text = "Name";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtSurname;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(228, 24);
            this.layoutControlItem7.Text = "Surname";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtSallary;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(153, 24);
            this.layoutControlItem8.Text = "Sallary";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(42, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(181, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(551, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(228, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(504, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(153, 48);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(579, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 437);
            this.Controls.Add(this.layoutControlManagers);
            this.Name = "ManagersForm";
            this.Text = "Managers";
            this.Load += new System.EventHandler(this.ManagersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlManagers)).EndInit();
            this.layoutControlManagers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSallary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlManagers;
        private DevExpress.XtraGrid.GridControl grdManagers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvManagers;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnSaveClose;
        private DevExpress.XtraGrid.Columns.GridColumn grdColName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSallary;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BindingSource bsManagers;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.TextEdit txtSallary;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}