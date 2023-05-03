using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkLibrary
{
    public class Generators
    {
        public string WelcomeMessage(string prefix, string LastName)
        {
            return $"Welcome to our demo application {prefix} {LastName}";
        }

        public string FarewellMessage(string prefix, string LastName)
        {
            return $"I hope you have enjoyed our time with us {prefix} {LastName} please come back soon";
        }
    }
}
