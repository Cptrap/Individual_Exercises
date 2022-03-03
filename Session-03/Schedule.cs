using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Schedule
    {
        public Guid ScheduleID { get; }
        public Guid CourseID { get; }
        public Guid ProfessorID { get; }
        public DateTime Calendar { get; set; }
        public Schedule() 
        { 
            ScheduleID = Guid.NewGuid();
            CourseID = Guid.NewGuid();
            ProfessorID = Guid.NewGuid();
        }

    }
}
