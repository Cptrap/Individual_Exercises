using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Session_014.EF.Repositories;
using Session_14.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_14
{
    public partial class EngineerForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEntityRepo<Engineer> _engineerRepo;

        private List<Engineer> _engineers = new List<Engineer>();
        public EngineerForm()
        {
            InitializeComponent();
        }
        public EngineerForm(IEntityRepo<Engineer> engineerRepo)
        {
            InitializeComponent();
            _engineerRepo = engineerRepo;
        }
        private void EngineerForm_Load(object sender, EventArgs e)
        {
            SetRepManager();
            RefreshEngineers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();                        
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var engineerName = txtName.Text;
            var engineerSurname = txtSurname.Text;
            var engineerSallary = Convert.ToDecimal(txtSallary.Text);
            
            var engineer = new Engineer(engineerName, engineerSurname, engineerSallary);
            _engineerRepo.Create(engineer);
            RefreshEngineers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedIndexes = grvEngineers.GetSelectedRows();
            var selectedEngineer = grvEngineers.GetRow(selectedIndexes[0]) as Engineer;
            if (selectedEngineer is not null)
            {
                _engineerRepo.Delete(selectedEngineer.ID);
                RefreshEngineers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grvEngineers.RowCount > 0)
            {
                var selectedEngineer = TakeEngineer();
                if (selectedEngineer is not null)
                {
                    _engineerRepo.Update(selectedEngineer.ID, selectedEngineer);
                    RefreshEngineers();
                }
            }
        }
        private void grdEngineers_Click(object sender, EventArgs e)
        {
            LoadEngineer();
        }
        private void RefreshEngineers()
        {
            _engineers = _engineerRepo.GetAll();
            grdEngineers.DataSource = null;
            grdEngineers.DataSource = _engineers;
            grdEngineers.Refresh();
            grdEngineers.Update();
        }
        private Engineer? LoadEngineer()
        {
            var selectedIndexes = grvEngineers.GetSelectedRows();
            var selectedEngineer = grvEngineers.GetRow(selectedIndexes[0]) as Engineer;
            txtName.Text = selectedEngineer.Name;
            txtSurname.Text = selectedEngineer.Surname;
            txtSallary.Text = Convert.ToString(selectedEngineer.SallaryPerMonth);
            return selectedEngineer;

        }
        private Engineer? TakeEngineer()
        {
            var selectedIndexes = grvEngineers.GetSelectedRows();
            var upadateEngineer = grvEngineers.GetRow(selectedIndexes[0]) as Engineer;
            upadateEngineer.Name = txtName.Text;
            upadateEngineer.Surname = txtSurname.Text;
            upadateEngineer.SallaryPerMonth = Convert.ToDecimal(txtSallary.Text);
            return upadateEngineer;
        }
        private void SetRepManager()
        {
            bsEngineers.DataMember = "Engineers";

            grdEngineers.DataSource = bsEngineers.CurrencyManager;
            ctrlManager.Properties.DataSource = bsEngineers;
            ctrlManager.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            ctrlManager.Properties.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            ctrlManager.Properties.DisplayMember = "Name";
            ctrlManager.Properties.ValueMember = "ID";
            repManager.DataSource = bsEngineers.CurrencyManager;
            repManager.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            repManager.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            repManager.DisplayMember = "Name";
            repManager.ValueMember = "ID";
        }


    }
}