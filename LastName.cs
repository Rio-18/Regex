﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    internal class RegexPatten
    {

        public void ValidateName(string firstName, string lastName)
        {
            string NamePatten = "^[A-Z][a-z]{3,}?";

            if (Regex.IsMatch(firstName, NamePatten))
            {
                Console.WriteLine("First Name is Valid");
            }
            else
            {
                Console.WriteLine("First Name not Valid ");
            }
            if (Regex.IsMatch(lastName, NamePatten))
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Last Name not Valid ");
            }
        }


    }
}
