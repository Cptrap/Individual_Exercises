using DevExpress.XtraEditors;
using Session_014.EF.Repositories;
using Session_14.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_14
{
    public partial class ManagersForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEntityRepo<Manager> _managerRepo;

        private List<Manager> _managers = new List<Manager>();
        public ManagersForm()
        {
            InitializeComponent();

        }
        public ManagersForm(IEntityRepo<Manager> managerRepo)
        {
            InitializeComponent();
            _managerRepo = managerRepo;

        }
        private void ManagersForm_Load(object sender, EventArgs e)
        {
            RefreshManagers();
        }

        private void gridControlManagers_Click(object sender, EventArgs e)
        {
            LoadManager();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var managerName = txtName.Text;
            var managerSurname = txtSurname.Text;
            var managerSallary = Convert.ToDecimal(txtSallary.Text);
            var manager = new Manager(managerName, managerSurname, managerSallary);
            _managerRepo.Create(manager);
            RefreshManagers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grvManagers.RowCount > 0)
            {
                var selectedManager = TakeManager();
                if (selectedManager is not null)
                {
                    _managerRepo.Update(selectedManager.ID, selectedManager);
                    RefreshManagers();
                }
            }

        }
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedIndexes = grvManagers.GetSelectedRows();
            var selectedManager = grvManagers.GetRow(selectedIndexes[0]) as Manager;
            if (selectedManager is not null)
            {
                _managerRepo.Delete(selectedManager.ID);
                RefreshManagers();
            }

        }
        private void RefreshManagers()
        {
            _managers = _managerRepo.GetAll();
            grdManagers.DataSource = null;
            grdManagers.DataSource = _managers;
            grdManagers.Refresh();
            grdManagers.Update();
        }
        private Manager? LoadManager()
        {
            var selectedIndexes = grvManagers.GetSelectedRows();
            var selectedManager = grvManagers.GetRow(selectedIndexes[0]) as Manager;
            txtName.Text = selectedManager.Name;
            txtSurname.Text = selectedManager.Surname;
            txtSallary.Text = Convert.ToString(selectedManager.SallaryPerMonth);
            return selectedManager;

        }
        private Manager? TakeManager()
        {
            var selectedIndexes = grvManagers.GetSelectedRows();
            var upadateManager = grvManagers.GetRow(selectedIndexes[0]) as Manager;
            upadateManager.Name = txtName.Text;
            upadateManager.Surname = txtSurname.Text;
            upadateManager.SallaryPerMonth = Convert.ToDecimal(txtSallary.Text);
            return upadateManager;
        }


    }
}