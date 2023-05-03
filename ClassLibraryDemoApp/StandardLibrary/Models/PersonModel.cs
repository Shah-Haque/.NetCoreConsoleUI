using System;
using System.Collections.Generic;
using System.Text;

namespace StandardLibrary.Models
{
    public class PersonModel
    {
        public string Prefix { get; set; } // Mr, Mrs, Miss, Ms, Dr etc

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
