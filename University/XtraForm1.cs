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
using InstituteLib;
using System.Configuration;

namespace Session_08
{
    public enum Enum
    {
        University = 1,
        Professor = 2,
        Student = 3,
        Course = 4,
        Schedule = 5,
        Grade = 6
    }

    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
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
        
        
        


        public XtraForm1()
        {
            InitializeComponent();
            _university = new InstituteLib.University("Auth", 1925);
            _university.Courses = new List<Course>();
            var mathematics = new Course()
            {
                Subject = "Mathematics",
                Code = "000001"
            };
            _university.Courses.Add(mathematics);
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                LoadData(i);
            }
            

        }

        private void editUniversity_Click(object sender, EventArgs e)
        {
            University university = new University();
            university.ShowDialog();
        }

        private void editProfessor_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.ShowDialog();
        }

        private void editStudent_Click(object sender, EventArgs e)
        {
            StudentF studentForm = new StudentF();
            //studentForm.Students = _university.Students;
            studentForm.ShowDialog();
        }

        private void editCourse_Click(object sender, EventArgs e)
        {

            if (_university != null && _university.Courses.Count() > 0)
            {
                CourseForm courseForm = new CourseForm();
                //courseForm = _university.Courses;
                courseForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Courses are not loaded!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void editSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.ShowDialog();
        }

        private void editGrade_Click(object sender, EventArgs e)
        {
            Grade grade = new Grade();
            grade.ShowDialog();
        }
        

        private void saveUniversity_Click(object sender, EventArgs e)
        {
            SaveData(1);
            MessageBox.Show("File Saved!");
        }

        private void saveProfessor_Click(object sender, EventArgs e)
        {
            SaveData(2);
            MessageBox.Show("File Saved!");
        }

        private void saveStudent_Click(object sender, EventArgs e)
        {
            SaveData(3);
            MessageBox.Show("File Saved!");
        }

        private void saveCourse_Click(object sender, EventArgs e)
        {
            SaveData(4);
            MessageBox.Show("File Saved!");
        }

        private void saveSchedule_Click(object sender, EventArgs e)
        {
            SaveData(5);
            MessageBox.Show("File Saved!");
        }

        private void saveGrade_Click(object sender, EventArgs e)
        {
            SaveData(6);
            MessageBox.Show("File Saved!");
        }
        private void loadUniversity_Click(object sender, EventArgs e)
        {
            LoadData(1);
            MessageBox.Show("Loaded OK!");
        }

        private void loadProfessor_Click(object sender, EventArgs e)
        {
            LoadData(2);
            MessageBox.Show("Loaded OK!");
        }

        private void loadStudent_Click(object sender, EventArgs e)
        {
            LoadData(3);
            MessageBox.Show("Loaded OK!");
        }

        private void loadCourse_Click(object sender, EventArgs e)
        {
            LoadData(4);
            MessageBox.Show("Loaded OK!");
        }

        private void loadSchedule_Click(object sender, EventArgs e)
        {
            LoadData(5);
            MessageBox.Show("Loaded OK!");
        }

        private void loadGrade_Click(object sender, EventArgs e)
        {
            LoadData(6);
            MessageBox.Show("Loaded OK!");
        }

        

        private void LoadData(int option)
        {

            switch (option)
            {
                case (int)Enum.University:
                    s = File.ReadAllText(FILE_NAME_UNIVERSITY);
                    _university = (InstituteLib.University)JsonSerializer.Deserialize(s, typeof(InstituteLib.University));
                    break;
                case (int)Enum.Professor:
                    s = File.ReadAllText(FILE_NAME_PROFESSOR);
                    _professor = (InstituteLib.Professor)JsonSerializer.Deserialize(s, typeof(InstituteLib.Professor));
                    break;
                case (int)Enum.Student:
                    s = File.ReadAllText(FILE_NAME_STUDENT);
                    _student = (InstituteLib.Student)JsonSerializer.Deserialize(s, typeof(InstituteLib.Student));
                    break;
                case (int)Enum.Course:
                    s = File.ReadAllText(FILE_NAME_COURSE);
                    _course = (Course)JsonSerializer.Deserialize(s, typeof(Course));
                    break;
                case (int)Enum.Schedule:
                    s = File.ReadAllText(FILE_NAME_SCHEDULE);
                    _schedule = (InstituteLib.Schedule)JsonSerializer.Deserialize(s, typeof(InstituteLib.Schedule));
                    break;
                case (int)Enum.Grade:
                    s = File.ReadAllText(FILE_NAME_GRADE);
                    _grade = (InstituteLib.Grade)JsonSerializer.Deserialize(s, typeof(InstituteLib.Grade));
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
                    break;
                case (int)Enum.Professor:
                    json = JsonSerializer.Serialize(_professor);
                    File.WriteAllText(FILE_NAME_PROFESSOR, json);
                    break;
                case (int)Enum.Student:
                    json = JsonSerializer.Serialize(_student);
                    File.WriteAllText(FILE_NAME_STUDENT, json);
                    break;
                case (int)Enum.Course:
                    json = JsonSerializer.Serialize(_course);
                    File.WriteAllText(FILE_NAME_COURSE, json);
                    break;
                case (int)Enum.Schedule:
                    json = JsonSerializer.Serialize(_schedule);
                    File.WriteAllText(FILE_NAME_SCHEDULE, json);
                    break;
                case (int)Enum.Grade:
                    json = JsonSerializer.Serialize(_grade);
                    File.WriteAllText(FILE_NAME_GRADE, json);
                    break;
                default:
                    break;

            }

        }

        private void XtraForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            for(int i=1; i <= 6; i++)
            {
                SaveData(i);
            }
            MessageBox.Show("All Files Saved!");
        }
    }
}