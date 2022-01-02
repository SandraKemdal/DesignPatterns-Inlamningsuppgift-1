using Design_Patterns_Assignment.Strategy.MessageTypes;
using System;

namespace Design_Patterns_Assignment.Strategy
{
    internal class MessageHandler 
    {
        public IMessenger Messenger { get; set; }
        internal void SendMessage(string message)
        {
            Messenger.SendMessage(message);
        }
    }
}