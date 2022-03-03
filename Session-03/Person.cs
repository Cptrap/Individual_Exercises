using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {
        public Guid ID { get; }
        public string _name;
        private int Age { get; set; }

        public string GetName() { 
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public Person() 
        {            
            ID = Guid.NewGuid();
            
        }

    }

   
}
