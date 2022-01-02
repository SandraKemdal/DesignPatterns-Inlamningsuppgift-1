using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment.Repository
{
    internal class Repository
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");

            var data = DataRepository.GetAll("Dataset A");
            var customer = DataRepository.GetAll("From Table Customer Where Name == Steve"); // this is a search
            var animal = DataRepository.GetAll("From Table Animal Where Owner == Steve"); // this is a search
           
            DataRepository.SaveData(data);
            DataRepository.SaveData(customer);
            DataRepository.SaveData(animal);

            Console.WriteLine();
        }
    }
}