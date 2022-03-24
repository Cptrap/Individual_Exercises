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
using Microsoft.Extensions.DependencyInjection;
using Session_014.EF.Repositories;
using Session_14.Model;

namespace Session_14
{

    public partial class CarServiceCenterForm : DevExpress.XtraEditors.XtraForm 
    {
        
        public static IServiceProvider ServiceProvider { get; private set; }

        public CarServiceCenterForm()
        {
            InitializeComponent();
        }

        private void CarServiceCenterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void editCustomer_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IEntityRepo<Customer>, CustomerRepo>();
            services.AddSingleton<CustomerForm>();
            ServiceProvider = services.BuildServiceProvider();
            var customerForm = ServiceProvider.GetRequiredService<CustomerForm>();
            customerForm.ShowDialog();
        }

        private void editCar_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IEntityRepo<Car>, CarRepo>();
            services.AddSingleton<CarForm>();
            ServiceProvider = services.BuildServiceProvider();
            var carForm = ServiceProvider.GetRequiredService<CarForm>();
            carForm.ShowDialog();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IEntityRepo<Manager>, ManagerRepo>();
            services.AddSingleton<ManagersForm>();
            ServiceProvider = services.BuildServiceProvider();
            var managerForm = ServiceProvider.GetRequiredService<ManagersForm>();
            managerForm.ShowDialog();
        }

        private void editServiceTask_Click(object sender, EventArgs e)
        {
            //openF.Open<ServiceTaskForm>();
        }
        private void editEngineer_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IEntityRepo<Engineer>, EngineerRepo>();
            services.AddSingleton<EngineerForm>();
            ServiceProvider = services.BuildServiceProvider();
            var engineerForm = ServiceProvider.GetRequiredService<EngineerForm>();
            engineerForm.ShowDialog();
        }
        private void newTrasaction_Click(object sender, EventArgs e)
        {
            //openF.Open<TransactionForm>();
        }




        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void monthlyLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openF.Open<MonthlyLedgerForm>();
        }
    }

}