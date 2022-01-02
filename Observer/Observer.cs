using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer
{
    class Observer
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");

            Email email = new();
            EmailWatcher EmailWatcher = new();
            email.UpdateEmail();
            email.RegisterObserver(EmailWatcher);

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Press A to Add observer");
                Console.WriteLine("Press R to Remove observer");
                Console.WriteLine("Press U to Update observer");
                Console.WriteLine("Press X to Exit Program\n");

                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'A' or 'a':
                        email.RegisterObserver(EmailWatcher);
                        Console.WriteLine("Observer Registered\n");
                        break;
                    case 'R' or 'r':
                        email.UnRegisterObserver(EmailWatcher);
                        Console.WriteLine("Observer Unregistered\n");
                        break;
                    case 'U' or 'u':
                        email.UpdateEmail();
                        break;
                    case 'X' or 'x':
                        Console.WriteLine("\nExiting program");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Unkown command, please try again.\n");
                        break;
                }

            }
        }
    }
}
