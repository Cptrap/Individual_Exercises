using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07
{
    public partial class Institute : Form
    {
        public Institute()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void universityEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            University university = new University();
            university.Show();
        }

        private void professorEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Professor professor = new Professor();
            professor.Show();
        }

        private void studentEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Student student = new Student();
            student.Show();
        }

        private void courseEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Course course = new Course();
            course.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void scheduleEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.Show();
        }

        private void gradeEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Grade grade = new Grade();
            grade.Show();
        }
    }
}
