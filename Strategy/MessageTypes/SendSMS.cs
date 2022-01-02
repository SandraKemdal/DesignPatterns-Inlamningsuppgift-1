using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.MessageTypes
{
    class SendSMS : IMessenger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as an sms");
        }
    }
}
