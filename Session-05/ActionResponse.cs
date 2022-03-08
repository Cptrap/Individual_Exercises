using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResponse{
        public Guid ResponseId { get; set; } 
        public Guid RequestId { get; set;}
        public string Output { get; set; }
        public ActionResponse(Guid responseId, Guid requestId, string output){
            ResponseId = responseId;
            RequestId = requestId;
            Output = output;
        }
        
    }
}
