using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using InstituteLib;


namespace Session_07
{
    public enum Enum
    {
        University=1,
        Professor=2,
        Student=3,
        Course=4,
        Schedule=5,
        Grade=6
    }
    
    public partial class Institute : Form
    {
        //Json files to storage the data
        private const string FILE_NAME_UNIVERSITY = "university.json";
        private const string FILE_NAME_PROFESSOR = "professor.json";
        private const string FILE_NAME_STUDENT = "student.json";
        private const string FILE_NAME_COURSE = "course.json";
        private const string FILE_NAME_SCHEDULE = "schedule.json";
        private const string FILE_NAME_GRADE = "grade.json";

        private string s;
        private string json;
        private int option;

        //Instantiate our objects from our library
        private InstituteLib.Course _course;
        private InstituteLib.Schedule _schedule;
        private InstituteLib.Grade _grade;
        private InstituteLib.Student _student;
        private InstituteLib.Professor _professor;
        private InstituteLib.University _university;


        public Institute()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #region UIcontrols
        private void Institute_Load(object sender, EventArgs e)
        {

        }
        private void universityEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            University university = new University();
            university.ShowDialog();
        }

        private void professorEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Professor professor = new Professor();
            professor.ShowDialog();
        }

        private void studentEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Student student = new Student();
            student.ShowDialog();
        }

        private void courseEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Course course = new Course();
            course.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void scheduleEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.ShowDialog();
        }

        private void gradeEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Grade grade = new Grade();
            grade.ShowDialog();
        }

        private void universitySave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData(1);
        }

        private void universityLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData(1);
        }

        private void professorLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData(2);
        }

        private void studentLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData(3);
        }

        private void courseLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData(4);
        }

        private void scheduleLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData(5);
        }

        private void gradeLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData(6);
        }

        private void professorSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData(2);
        }

        private void studentSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData(3);
        }

        private void courseSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData(4);
        }

        private void scheduleSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData(5);
        }

        private void gradeSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData(6);
        }
        #endregion UIcontrols
        private void LoadData(int option)
        {

            switch (option)
            {
                case (int)Enum.University:
                    s = File.ReadAllText(FILE_NAME_UNIVERSITY);
                    _university = (InstituteLib.University)JsonSerializer.Deserialize(s, typeof(InstituteLib.University));
                    MessageBox.Show("Loaded OK!");
                    break;
                case (int)Enum.Professor:
                    s = File.ReadAllText(FILE_NAME_PROFESSOR);
                    _professor = (InstituteLib.Professor)JsonSerializer.Deserialize(s, typeof(InstituteLib.Professor));
                    MessageBox.Show("Loaded OK!");
                    break;
                case (int)Enum.Student:
                    s = File.ReadAllText(FILE_NAME_STUDENT);
                    _student = (InstituteLib.Student)JsonSerializer.Deserialize(s, typeof(InstituteLib.Student));
                    MessageBox.Show("Loaded OK!");
                    break;
                case (int)Enum.Course:
                    s = File.ReadAllText(FILE_NAME_COURSE);
                    _course = (InstituteLib.Course)JsonSerializer.Deserialize(s, typeof(InstituteLib.Course));
                    MessageBox.Show("Loaded OK!");
                    break;
                case (int)Enum.Schedule:
                    s = File.ReadAllText(FILE_NAME_SCHEDULE);
                    _schedule = (InstituteLib.Schedule)JsonSerializer.Deserialize(s, typeof(InstituteLib.Schedule));
                    MessageBox.Show("Loaded OK!");
                    break;
                case (int)Enum.Grade:
                    s = File.ReadAllText(FILE_NAME_GRADE);
                    _grade = (InstituteLib.Grade)JsonSerializer.Deserialize(s, typeof(InstituteLib.Grade));
                    MessageBox.Show("Loaded OK!");
                    break;
                default:
                    break;
            }

        }
        private void SaveData(int option)
        {

            switch (option)
            {
                case (int)Enum.University:
                    json = JsonSerializer.Serialize(_university);
                    File.WriteAllText(FILE_NAME_UNIVERSITY, json);
                    MessageBox.Show("File Saved!");
                    break;
                case (int)Enum.Professor:
                    json = JsonSerializer.Serialize(_professor);
                    File.WriteAllText(FILE_NAME_PROFESSOR, json);
                    MessageBox.Show("File Saved!");
                    break;
                case (int)Enum.Student:
                    json = JsonSerializer.Serialize(_student);
                    File.WriteAllText(FILE_NAME_STUDENT, json);
                    MessageBox.Show("File Saved!");
                    break;
                case (int)Enum.Course:
                    json = JsonSerializer.Serialize(_course);
                    File.WriteAllText(FILE_NAME_COURSE, json);
                    MessageBox.Show("File Saved!");
                    break;
                case (int)Enum.Schedule:
                    json = JsonSerializer.Serialize(_schedule);
                    File.WriteAllText(FILE_NAME_SCHEDULE, json);
                    MessageBox.Show("File Saved!");
                    break;
                case (int)Enum.Grade:
                    json = JsonSerializer.Serialize(_grade);
                    File.WriteAllText(FILE_NAME_GRADE, json);
                    MessageBox.Show("File Saved!");
                    break;
                default:
                    break;

            }

        }
        private void Edit()
        {
            University university = new University();
            var Professors = new List<Professor>();
            var Courses = new List<Course>();
            var Students = new List<Student>();
            var Grades = new List<Grade>();
            var ScheduleCourses = new List<Schedule>();
            university.ShowDialog();
            
        }
        
    }
}

