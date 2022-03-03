using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute
    {
        public Student[] students;

        public Course[] courses;

        public Grade[] grades;

        public Schedule[] scheduledCourses;


        public Student GetStudents() { return students[30]; }
        public Course GetCourses() { return courses[50]; }
        public Grade GetGrades() { return grades[30]; }
        public Schedule GetScheduledCourses() { return scheduledCourses[30]; }


        public University()
        {


        }

        public void SetSchedule(Grade courseID,Grade professorID, DateTime dateTime) { }
     
    }
}
