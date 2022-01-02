using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Observer;
using Design_Patterns_Assignment.Repository;
using Design_Patterns_Assignment.Strategy;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* För att testa Observer kommentera bort Strategy & kommentera upp Observer. 
               De kan ej köras samtidigt.             
             */

            Decorator.Run(); 
            Repository.Run();
            Strategy.Run(); 
            //Observer.Run();
        }     
    }
}
