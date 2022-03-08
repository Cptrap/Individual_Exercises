using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver{

        public MessageLogger MessageLogger { get; set; }
        public ActionResolver(){
            MessageLogger = new MessageLogger();
        }
        //public static ActionResponse Execute()
        //{

        //    var action = new ActionEnum();
        //    switch (action)
        //    {
        //        case ActionEnum.Convert:
        //            return new ConvertResolver();
        //        case ActionEnum.Uppercase:
        //            return new UppercaseResolver();
        //        case ActionEnum.Reverse:
        //            return new ReverseResolver();
        //        default:
        //           return ;
                    
        //    }
                 
            
        //}

    }
}
