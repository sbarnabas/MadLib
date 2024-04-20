using System;
using System.Runtime.InteropServices;

namespace mabLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MadLibs class (this selects a random mad lib)
            MadLibs madLib = new MadLibs();
            //initialize a UserInput object with the values we need for the madlib
            UserInput input = new UserInput(madLib.Parameters);
            //prompt the user to fill in the blanks
            var values = input.GetUserValues();
            //print out the completed madlib
            madLib.Display(values);

            //if we want, we can prompt the user for different values
            // values = input.GetUserValues();
            // madLib.Display(values);
            //or start a new random madlib
            // madLib = new MadLibs();
        }
    }
}
