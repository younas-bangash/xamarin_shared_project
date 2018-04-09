using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject
{
    public class Strings
    {
        // Declare without initializing.
        string message1;

        // Initialize to null.
        string message2 = null;

        // Initialize as an empty string.
        // Use the Empty constant instead of the literal "".
        string message3 = System.String.Empty;
        
        public string newLine = "Hello word \n Hello word";
        
        public string newLine2 = @"Hello word \n Hello word";

        // Use System.String if you prefer.
        System.String greeting = "Hello World!";

        // Use a const string to prevent 'message4' from
        // being used to store another string value.
        public const string message4 = "You can't get rid of me!";

    }
}
