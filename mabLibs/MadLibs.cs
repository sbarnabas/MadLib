using System;

namespace mabLibs
{
    public class MadLibs
    {

        static Dictionary<string, Dictionary<string, string>> _allMadLibs;
        static MadLibs()
        {
            //statically populate the list of all madlibs 
            //the keys are the template strings, the values are the parameter dictionaries.
            //note that the format for template strings is totally up to you, but user input can cause unexpeted behavior
            _allMadLibs = new Dictionary<string, Dictionary<string, string>>();
            _allMadLibs.Add(@"
            This weekend I am going camping with !!ProperNounPersonName!!. I packed my lantern, sleeping bag, and !!Noun!!. 
            I am so !!AdjectiveFeeling!! to !!Verb!! in a tent. I am !!AdjectiveFeeling!! we might see a !!Animal!!, they are kind of dangerous.
             We are going to hike, fish, and !!Verb!!. I have heard that the !!Color!! lake is great for !!VerbEndingInIng!!. 
             Then we will !!AdverbEndingInLy!! hike through the forest for !!Number!! !!MeasureOfTime!!. If I see a !!Color2!! !!Animal!! while hiking, 
             I am going to bring it home as a pet! At night we will tell !!Number2!! !!SillyWord!! stories and roast !!Noun!! around the campfire!!
            ", new Dictionary<string, string> { {"!!ProperNounPersonName!!","Proper Noun (Name)"},
                                                {"!!Noun!!","Noun"},
                                                {"!!AdjectiveFeeling!!","Adjective (Feeling)"},
                                                {"!!Verb!!","Verb"},
                                                {"!!Animal!!","Animal"},
                                                {"!!Color!!","Color"},
                                                {"!!VerbEndingInIng!!","Verb (ending in -ing)"},
                                                {"!!AdverbEndingInLy!!","Adverb (ending in -ly)"},
                                                {"!!Number!!","Number"},
                                                {"!!MeasureOfTime!!","Measure of Time"},
                                                {"!!Color2!!","Another Color"},
                                                {"!!Number2!!","Another Number"},
                                                {"!!SillyWord!!","Silly Word"},
                                                });

           /*
                       // Mad Lib Two
            Console.WriteLine($"It was about {userInput.Nnumber} {userInput.MeasureOfTime} ago when I came to the hospital in a {userInput.ModeOfTransportation}.  \n" +
                $"The hospital is a/an {userInput.Adjective} place, there are a lot of {userInput.Adjective} {userInput.Noun} here. \n" +
                $"There are nurses here who have {userInput.Ccolor} {userInput.PartOfTheBody}. \n" +
                $"If someone wants to come into my room I told them that they have to {userInput.Verb} first. \n" +
                $"I have decorated my room with {userInput.Nnumber} {userInput.Noun}. \n" +
                $"Today a doctor came into my room and they were wearing a {userInput.Noun} on their {userInput.PartOfTheBody} .  \n" +
                $"I heard that all doctors {userInput.Verb} {userInput.Noun}   every day for breakfast.  \n" +
                $"The most {userInput.Adjective} thing about being in the hospital is the {userInput.SillyWord} {userInput.Noun}! \n");
                */
        }

        string templateString;
       public Dictionary<string,string> Parameters {get;}

        public MadLibs()
        {
            //on constuction, pick a madlib to use from the list
            Random r = new Random();
            var idx= r.Next(_allMadLibs.Count);
            templateString = _allMadLibs.ElementAt(idx).Key;
            Parameters=_allMadLibs.ElementAt(idx).Value;

        }
       public void Display(Dictionary<string,string> values) {
            string output = templateString;
            foreach(var key in values.Keys) { 
                output = output.Replace(key,values[key]);
            }
            Console.WriteLine(output);
       }
    }
}
