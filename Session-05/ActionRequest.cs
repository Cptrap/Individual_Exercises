﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public enum ActionEnum {
        Convert,
        Uppercase,
        Reverse
    }
    
    internal class ActionRequest {
        public Guid RequestId { get; set; }  
        public string Input { get; set; }
        public ActionEnum Action { get; set; }
        public ActionRequest(string input, ActionEnum action){
            RequestId = Guid.NewGuid();
            Input = Input;
            Action = action;
        }

    }

}
