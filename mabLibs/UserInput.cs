using System;

namespace mabLibs
{
    public class UserInput
    {
        // Properties to store user input values
        public string ProperNounPersonName { get; private set; }
        public string Noun { get; private set; }
        public string AdjectiveFeeling { get; private set; }
        public string Verb { get; private set; }
        public string Adjective { get; private set; }
        public string Animal { get; private set; }
        public string Ccolor { get; private set; }
        public string VerbEndingInIng { get; private set; }
        public string AdverbEndingInLy { get; private set; }
        public string Nnumber { get; private set; }
        public string MeasureOfTime { get; private set; }
        public string Color { get; private set; }
        public string SillyWord { get; private set; }
        public string ModeOfTransportation { get; private set; }
        public string PartOfTheBody { get; private set; }
        public string MagicalCreaturePlural { get; private set; }
        public string Place { get; private set; }
        public string RoomInAHouse { get; private set; }
        public string NounPlural { get; private set; }

        public UserInput()
        {
            // Prompt the user for input for each unique value
            Console.WriteLine("Proper Noun (Person’s Name):");
            ProperNounPersonName = Console.ReadLine();

            Console.WriteLine("Noun:");
            Noun = Console.ReadLine();

            Console.WriteLine("Adjective (Feeling):");
            AdjectiveFeeling = Console.ReadLine();

            Console.WriteLine("Verb:");
            Verb = Console.ReadLine();

            Console.WriteLine("Adjective:");
            Adjective = Console.ReadLine();

            Console.WriteLine("Animal:");
            Animal = Console.ReadLine();

            Console.WriteLine("Color:");
            Ccolor = Console.ReadLine();

            Console.WriteLine("Verb (ending in ing):");
            VerbEndingInIng = Console.ReadLine();

            Console.WriteLine("Adverb (ending in ly):");
            AdverbEndingInLy = Console.ReadLine();

            Console.WriteLine("Number:");
            Nnumber = Console.ReadLine();

            Console.WriteLine("Measure of Time:");
            MeasureOfTime = Console.ReadLine();

            Console.WriteLine("Color:");
            Color = Console.ReadLine();

            Console.WriteLine("Silly Word:");
            SillyWord = Console.ReadLine();

            Console.WriteLine("Mode of Transportation:");
            ModeOfTransportation = Console.ReadLine();

            Console.WriteLine("Part of the Body:");
            PartOfTheBody = Console.ReadLine();

            Console.WriteLine("Magical Creature (Plural):");
            MagicalCreaturePlural = Console.ReadLine();

            Console.WriteLine("Place:");
            Place = Console.ReadLine();

            Console.WriteLine("Room in a House:");
            RoomInAHouse = Console.ReadLine();

            Console.WriteLine("Noun (Plural):");
            NounPlural = Console.ReadLine();
        }
    }
}
