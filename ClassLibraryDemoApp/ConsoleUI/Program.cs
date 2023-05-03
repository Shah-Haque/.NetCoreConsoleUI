using StandardLibrary;
using StandardLibrary.Models;
using System;

namespace ConsoleUI
{

    internal class Program
    {
        static void Main(string[] args)
        {
           Generators generators = new Generators();

           PersonModel person = new PersonModel()
           {
               Prefix = "Mr",
               FirstName = "Shah",
               LastName = "Haque"
           };

           string message = generators.WelcomeMessage(person.Prefix,person.FirstName, person.LastName);

           Console.WriteLine(message);

           Console.ReadLine();
        }
    }
}