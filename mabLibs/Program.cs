using System;

namespace mabLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MadLibs class
            MadLibs madLibs = new MadLibs();

            // Call the method to display a random Mad Lib
            madLibs.DisplayRandomMadLib();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            Console.Clear();
        }
    }
}
