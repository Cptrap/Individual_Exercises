using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ActionResponse{
        public Guid ResponseId { get; set; } 
        public Guid RequestId { get; set;}
        public string Output { get; set; }
        public ActionResponse(){
            ResponseId = Guid.NewGuid();
            RequestId = Guid.NewGuid();
            
        }
        
    }
}
