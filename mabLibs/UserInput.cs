using System;

namespace mabLibs
{
    public class UserInput
    {
        private Dictionary<string, string> blanks;
        public UserInput(Dictionary<string, string> parameters)
        {
            blanks = parameters;
        }

        public Dictionary<string, string> GetUserValues()
        {
            Dictionary<string,string> values = new Dictionary<string, string>();

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
