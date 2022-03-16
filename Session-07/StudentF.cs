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
using DevExpress.DataAccess.ObjectBinding;
using System.Text.Json;
using System.IO;
using DevExpress.Utils.Extensions;

namespace Session_08
{
    public partial class StudentF : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME_STUDENT = "student.json";
        public InstituteLib.University _university;
        //public List<InstituteLib.Student>? Students { get; set; }
        //private InstituteLib.Student _student;


        public StudentF()
        {
            InitializeComponent();
        }

        private void StudentF_Load(object sender, EventArgs e)
        {
            _university = new InstituteLib.University("Auth", 1925);
            _university.Students = new List<InstituteLib.Student>();
            var student = new InstituteLib.Student();
            student.Name = "Stergios";

            student.Courses.Add(new Course() { Code = "000001", Subject = "Physics" });
            student.Courses.Add(new Course() { Code = "000002", Subject = "Mathematis" });
            student.Courses.Add(new Course() { Code = "000003", Subject = "Programming" });
            _university.Students.Add(student);
            bsStudents.DataSource = student;

            bsCourses.DataSource = bsStudents;
            bsCourses.DataMember = "Courses";
            grdCourses.DataSource = bsCourses;
            SetDataBindings();
        }


        private void bsStudents_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void xpBindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {

        }
        private void SetDataBindings()
        {
            ctrlName.DataBindings.Add(new Binding("EditValue", bsStudents, "Name", true));
            ctrlSurname.DataBindings.Add(new Binding("EditValue", bsStudents, "Surname", true));
            ctrlFullname.DataBindings.Add(new Binding("EditValue", bsStudents, "FullName", true));
            ctrlRegNumber.DataBindings.Add(new Binding("EditValue", bsStudents, "RegistrationNumber", true));
            ctrlAge.DataBindings.Add(new Binding("EditValue", bsStudents, "Age", true));
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(_university);
            File.WriteAllText(FILE_NAME_STUDENT, json);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateStudent();
        }
        private InstituteLib.Student CreateStudent()
        {
            StudentManager manager = new StudentManager();
            manager.Students = _university.Students;
            InstituteLib.Student student = manager.AddStudent();
            return student;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void DeleteStudent() {
            //if (_university.Students != null)
            //{
            //    _university.Students.Remove();
            //    _university.Students = null;
                
            //}
        }
    }
}