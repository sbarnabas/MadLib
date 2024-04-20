using System;

namespace mabLibs
{
    public class MadLibs
    {
        private Random random;
        private UserInput userInput;

        public MadLibs()
        {
            random = new Random();
            userInput = new UserInput();
        }

        public void DisplayRandomMadLib()
        {
            // Generate a random number to select which Mad Lib to display
            int madLibIndex = random.Next(2); // Assuming you have 2 Mad Libs

            // Select and display the chosen Mad Lib
            if (madLibIndex == 0)
            {
                MadLibOne();
            }
            else
            {
                MadLibTwo();
            }
        }

        private void MadLibOne()
        {
            // Mad Lib One
            Console.WriteLine($"This weekend I am going camping with {userInput.ProperNounPersonName}. I packed \n" +
               $"my lantern, sleeping bag, and {userInput.Noun}. I am so {userInput.AdjectiveFeeling} to {userInput.Verb} in a \n" +
               $"tent. I am {userInput.AdjectiveFeeling} we might see a {userInput.Animal}, they are kind of dangerous. \n" +
               $"We are going to hike, fish, and {userInput.Verb}. I have heard that the \n" +
               $"{userInput.Ccolor} lake is great for {userInput.VerbEndingInIng}. Then we will {userInput.AdverbEndingInLy} hike through \n" +
               $"the forest for {userInput.Nnumber} {userInput.MeasureOfTime}. If I see a {userInput.Color} {userInput.Animal} \n" +
               $"while hiking, I am going to bring it home as a pet! At night we will \n" +
               $"tell {userInput.Nnumber} {userInput.SillyWord} stories and roast {userInput.Noun} around the \n" +
               $"campfire!!");
        }

        private void MadLibTwo()
        {
            // Mad Lib Two
            Console.WriteLine($"It was about {userInput.Nnumber} {userInput.MeasureOfTime} ago when I came to the hospital in a {userInput.ModeOfTransportation}.  \n" +
                $"The hospital is a/an {userInput.Adjective} place, there are a lot of {userInput.Adjective} {userInput.Noun} here. \n" +
                $"There are nurses here who have {userInput.Ccolor} {userInput.PartOfTheBody}. \n" +
                $"If someone wants to come into my room I told them that they have to {userInput.Verb} first. \n" +
                $"I have decorated my room with {userInput.Nnumber} {userInput.Noun}. \n" +
                $"Today a doctor came into my room and they were wearing a {userInput.Noun} on their {userInput.PartOfTheBody} .  \n" +
                $"I heard that all doctors {userInput.Verb} {userInput.Noun}   every day for breakfast.  \n" +
                $"The most {userInput.Adjective} thing about being in the hospital is the {userInput.SillyWord} {userInput.Noun}! \n");
        }
    }
}
