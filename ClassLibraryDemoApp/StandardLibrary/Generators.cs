using System;
using System.Collections.Generic;
using System.Text;

namespace StandardLibrary
{
    public class Generators
    {
        public string WelcomeMessage(string prefix, string FirstName,string LastName)
        {
            return $"Welcome to our demo application {prefix} {FirstName} {LastName}";
        }

        public string FarewellMessage(string prefix, string LastName)
        {
            return $"I hope you have enjoyed our time with us {prefix} {LastName} please come back soon";
        }
    }
}
