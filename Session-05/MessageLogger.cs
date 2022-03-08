using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class MessageLogger{
        private Message[] Messages { get; set; }
        private int index = 0;
        private int messageNumber;
        public MessageLogger(int i=200){
            Messages = new Message[i];
            messageNumber = i;
        }
        public Message[] ReadAll()
        {
            return Messages;
        }
        public void Clear()
        {
            Array.Clear(Messages, 0, Messages.Length);
        }
        public void Write(Message message)
        {
            Messages[index] = message;
            index++;

        }



    }
}
