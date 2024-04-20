using System;

namespace mabLibs
{
    public class UserInput
    {
        private Dictionary<string, string> blanks;
        /// <summary>
        /// This object takes a Dictionary of parameters, 
        /// with the keys being the parameter name, and the value being the prompt the user sees.
        /// </summary>
        /// <param name="parameters">Dictionary<string,string> of parameters</param>
        public UserInput(Dictionary<string, string> parameters)
        {
            blanks = parameters;
        }

        /// <summary>
        /// This method prompts the user for values for each item in the parameter dictionary.
        /// It does not save values in between calls, and will prompt the user again each time.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetUserValues()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            foreach (var key in blanks.Keys)
            {
                string val = string.Empty;
                do
                {
                    Console.WriteLine($"Enter a value for {blanks[key]}:");
                    val = Console.ReadLine() ?? "";
                } while (String.IsNullOrEmpty(val));
                values.Add(key, val);

            }
            return values;
        }
    }
}
