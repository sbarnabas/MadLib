using System;

namespace mabLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MadLibs class
            MadLibs madLib = new MadLibs();

            UserInput input = new UserInput(madLib.Parameters);
            var values = input.GetUserValues();
            madLib.Display(values);
        }
    }
}
