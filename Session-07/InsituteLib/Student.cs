using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteLib
{
    [Serializable]
    public class Student : Person
    {
        
        public int RegistrationNumber { get; set; }
        //List<Course> Courses = new List<Course>();

        //public Student(string name, string surname, int age, int registrationNumber) : base(name, surname, age)
        //{
        //    RegistrationNumber = registrationNumber;
        //}
        public Student()
        {

        }
    }
    public class StudentManager : Manager
    {

        public List<Student> Students { get; set; }
        public StudentManager()
        {
            Students = new List<Student>();
        }
        //public Student AddStudent()
        //{
        //    return AddStudent();
        //}
        public Student AddStudent()
        {
            Student student = new Student();
            
            Students.Add(student);
            return student;
        }
    }
}
