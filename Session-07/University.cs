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
    public partial class University : Form
    {
        private InstituteLib.University _university;
        public string name;
        public int years;

        public List<Course> Courses { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Student> Students { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduleCourses { get; set; }
        


        public University()
        {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e)
        {
            //_university = new InstituteLib.University(name, years);
            //_university.Professors = new List<Professor>();
            //_university.Courses = new List<Course>();
            //_university.Students = new List<Student>();
            //_university.Grades = new List<Grade>();
            //_university.ScheduleCourses = new List<Schedule>();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
