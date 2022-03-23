using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.Json;
using System.IO;
using Session_14.Model;
using Session_014.EF.Repositories;

namespace Session_14
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        
        private readonly IEntityRepo<Customer> _customerRepo;

        private List<Customer> _customers = new List<Customer>();

        public CustomerForm()
        {
            InitializeComponent();
        }
        public CustomerForm(IEntityRepo<Customer> customerRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;

        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            
            RefreshCustomers();
        }
        #region UI Controls
        private void btnNew_Click(object sender, EventArgs e)
        {       
            var customerName = ctrlName.Text;
            var customerSurname = ctrlSurname.Text;
            var customerPhone = ctrlPhone.Text;
            var customerTIN = ctrlTIN.Text;
            var customer = new Customer(customerName, customerSurname, customerPhone, customerTIN);
            _customerRepo.Create(customer);
            RefreshCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            var selectedIndexes = grvCustomers.GetSelectedRows();
            var selectedCustomer = grvCustomers.GetRow(selectedIndexes[0]) as Customer;
            if (selectedCustomer is not null)
            {
                _customerRepo.Delete(selectedCustomer.ID);
                RefreshCustomers();
            }
           
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grvCustomers.RowCount > 0)
            {
                var selectedCustomer = TakeCustomer();
                if (selectedCustomer is not null)
                {
                    _customerRepo.Update(selectedCustomer.ID, selectedCustomer);
                    RefreshCustomers();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        #endregion
        private void RefreshCustomers()
        {
            _customers = _customerRepo.GetAll();
            grdCustomers.DataSource = null;
            grdCustomers.DataSource = _customers;
            grdCustomers.Refresh();
            grdCustomers.Update();
        }

        private void grdCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        private Customer? LoadCustomer()
        {
            var selectedIndexes = grvCustomers.GetSelectedRows();
            var selectedCustomer = grvCustomers.GetRow(selectedIndexes[0]) as Customer;
            ctrlName.Text = selectedCustomer.Name;
            ctrlSurname.Text = selectedCustomer.Surname;
            ctrlPhone.Text = selectedCustomer.Phone;
            ctrlTIN.Text = selectedCustomer.TIN;
            return selectedCustomer;

        }
        private Customer? TakeCustomer()
        {
            var selectedIndexes = grvCustomers.GetSelectedRows();
            var upadateCustomer = grvCustomers.GetRow(selectedIndexes[0]) as Customer;
            upadateCustomer.Name = ctrlName.Text;
            upadateCustomer.Surname = ctrlSurname.Text;
            upadateCustomer.Phone = ctrlPhone.Text;
            upadateCustomer.TIN = ctrlTIN.Text;
            return upadateCustomer;
        }
    }


}