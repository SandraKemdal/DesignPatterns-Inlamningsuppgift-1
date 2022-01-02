using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.MessageTypes
{
    class SendEmail : IMessenger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as an email");
        }
    }
}
