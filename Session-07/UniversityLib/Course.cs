using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteLib
{
    [Serializable]
    public class Course
    {
        public Guid ID { get; }
        public string Code { get; set; }
        public string Subject { get; set; }
        public Course()
        {
            ID = Guid.NewGuid();
            Subject = string.Empty;
            Code = string.Empty;

        }
        public class Manager
        {

        }

        public class CourseManager : Manager
        {
           
            public List<Course> Courses { get; set; }
            public CourseManager()
            {
                Courses = new List<Course>();
            }


            public Course AddCourse()
            {

                return AddCourse("{enter name}", "0");
            }

            public Course AddCourse(string subject)
            {

                return AddCourse(subject, "0");
            }

            public Course AddCourse(string subject, string code)
            {

                Course course = new Course()
                {
                    Subject = subject,
                    Code = code,
                };

                Courses.Add(course);

                return course;
            }

        }
    }
}
