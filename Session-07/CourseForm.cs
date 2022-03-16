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
using InstituteLib;

namespace Session_08
{
    public partial class CourseForm : DevExpress.XtraEditors.XtraForm
    {
        public List<Course> Courses { get; set; }
        private InstituteLib.University _university;
        private Course _selectedCourse;
        public CourseForm()
        {
            InitializeComponent();
        }

        private void Course2_Load(object sender, EventArgs e)
        {
            ShowList();

            _selectedCourse = new Course();
            _university.Courses = new List<Course>();
            var mathematics = new Course()
            {

                Subject = "Mathematics",
                Code = "000001"
            };
            var physics = new Course()
            {
                Subject = "Physics",
                Code = "000002"
            };
            var programming = new Course()
            {
                Subject = "Programming",
                Code = "000003"
            };
            _university.Courses.Add(physics);
            _university.Courses.Add(mathematics);
            _university.Courses.Add(programming);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCourse();
            DisplayCourse();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateCourse();
            ShowList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCourse();
            ShowList();
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Course course = CreateCourse();
            ShowList();
            listView.SelectedIndex = Courses.IndexOf(course);
        }
        private Course CreateCourse()
        {
            CourseManager manager = new CourseManager();
            manager.Courses = Courses;
            Course course = manager.AddCourse();
            return course;
        }

        private void ShowList()
        {
            listView.Items.Clear();
            foreach (Course item in Courses)
            {

                if (item != null)
                    listView.Items.Add(string.Format("{0}", item.Subject));
            }
        }
        private void DeleteCourse()
        {

            if (_selectedCourse != null)
            {
                Courses.Remove(_selectedCourse);
                _selectedCourse = null;
                ShowList();
            }
            DisplayCourse();
            
        }
        private void SelectCourse()
        {

            if (_selectedCourse != null)
                _selectedCourse = Courses[listView.SelectedIndex];
        }
        private void DisplayCourse()
        {

            if (_selectedCourse != null)
            {
                txtSubject.Text = _selectedCourse.Subject;
                txtCode.Text = _selectedCourse.Code;
            }
            else
            {
                txtSubject.Text = string.Empty;
                txtCode.Text = string.Empty;
            }
        }
        private void UpdateCourse()
        {
            if (_selectedCourse != null)
            {
                _selectedCourse.Subject = txtSubject.Text;
                _selectedCourse.Code = txtCode.Text;

            }
            else
            {
                txtSubject.Text = string.Empty;
                txtCode.Text = string.Empty;
            }
        }

        
    }
}