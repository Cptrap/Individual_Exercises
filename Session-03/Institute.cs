using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institute
    {
        public Guid ID { get; }
        public string instituteName;

        private int YearsInService { get; set; }
        public string GetName()
        {
            return instituteName;
        }
        public void SetName(string name)
        {
            instituteName = name;
        }
        public Institute() 
        { 
            ID = Guid.NewGuid();
        }
    }
}
