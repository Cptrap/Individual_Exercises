using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InstituteLib
{
    [Serializable]
    public class University : Institute
    {
        public List<Course> Courses { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Student> Students { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduleCourses { get; set; }
        public University(string name, int yearsInService) : base(name, yearsInService)
        {
            Courses = new List<Course>();
            Professors = new List<Professor>();
            Students = new List<Student>();
            Grades = new List<Grade>();
            ScheduleCourses = new List<Schedule>();

        }
    }
}
