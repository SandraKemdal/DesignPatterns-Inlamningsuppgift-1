using Design_Patterns_Assignment.Strategy.MessageTypes;
using System;

namespace Design_Patterns_Assignment.Strategy
{
    internal class Strategy
    {
        internal static void Run()
        {
            MessageHandler messageHandler = new();
            SendEmail sendEmail = new();
            SendSMS sendSMS = new();
            SendFacebookMessage sendFacebookMessage = new();
           
            Console.WriteLine("Strategy ");

            while (true)
            {
                var message = "This is the message";
                
                Console.WriteLine("\nChoose Message type below\n");
                Console.WriteLine("E: Email");
                Console.WriteLine("S: SMS");
                Console.WriteLine("F: Facebook Message");
                Console.WriteLine("X: Exit the Program\n");

                var userInput = Console.ReadKey(true).KeyChar;
                
                switch (userInput)
                {
                    case 'E' or 'e':
                        Console.Clear();
                        messageHandler.Messenger = sendEmail;
                        messageHandler.SendMessage(message);
                        break;
                    case 'S' or 's':
                        Console.Clear();
                        messageHandler.Messenger = sendSMS;
                        messageHandler.SendMessage(message);
                        break;
                    case 'F' or 'f':
                        Console.Clear();
                        messageHandler.Messenger = sendFacebookMessage;
                        messageHandler.SendMessage(message);
                        break;
                    case 'X' or 'x':
                        Console.WriteLine("\nExiting program");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nUnkown command, please try again.");
                        break;
                }

            }

  
        }
    }
}