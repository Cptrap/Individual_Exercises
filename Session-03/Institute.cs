﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institute
    {
        public Guid ID { get; }
        public string _name;

        private int YearsInService { get; set; }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public Institute() 
        { 
            ID = Guid.NewGuid();
        }
    }
}
