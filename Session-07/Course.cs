using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstituteLib;

namespace Session_07
{
    public partial class Course : Form
    {
        
        public List<Course> Courses { get; set; }
        public Course()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Course_Load(object sender, EventArgs e)
        {
            //_course = new InstituteLib.Course();
            //var physics = new InstituteLib.Course()
            //{
            //    Subject = "Physics",
            //    Code = "1"     
            //};
            //var mathematics = new InstituteLib.Course()
            //{
            //    Subject = "Mathematics",
            //    Code = "1"
            //};
            //_university.Courses[0] = physics;
            //_university.Courses[1] = mathematics;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Course course = CreateCourse();
        }
        //private Course CreateCourse()
        //{
        //    InstituteLib.Course.CourseManager manager = new InstituteLib.Course.CourseManager();
        //    manager.Courses = Courses;

        //    Course course = manager.AddCourse();


        //    return course;
        //}
    }
}
