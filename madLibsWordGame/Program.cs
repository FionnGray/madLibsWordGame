using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a Mad Libs word game. It'll prompt the user to enter various words and use those words to fill in the blanks in the story. The end result will be a totally wacky random story!
            Author: Hey there! My name's Fionn Gray and I'm an aspiring developer using Codecademy as my platform of choice on my coding journey!
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Hi there and welcome to...");

            // Give the Mad Lib a title:
            string title = "Fionn's Mad Libs Word Game";

            Console.WriteLine(title.ToUpper());
            // Define user input and variables:
            //Character name
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            //Adjectives
            Console.WriteLine("Enter your first adjective: ");
            string adjOne = Console.ReadLine();
            Console.WriteLine("Enter a second adjective: ");
            string adjTwo = Console.ReadLine();
            Console.WriteLine("And one last adjective:");
            string adjThree = Console.ReadLine();

            //Verb
            Console.WriteLine("Enter a verb: ");
            string verb = Console.ReadLine();

            //Nouns
            Console.WriteLine("Enter your first noun: ");
            string nounOne = Console.ReadLine();
            Console.WriteLine("And now a second noun: ");
            string nounTwo = Console.ReadLine();

            //Randoms
            Console.WriteLine("Enter an animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine("Enter a food: ");
            string food = Console.ReadLine();
            Console.WriteLine("Enter a fruit: ");
            string fruit = Console.ReadLine();
            Console.WriteLine("Enter a superhero: ");
            string superHero = Console.ReadLine();
            Console.WriteLine("Enter a country: ");
            string country = Console.ReadLine();
            Console.WriteLine("Enter a dessert: ");
            string dessert = Console.ReadLine();
            Console.WriteLine("And last but certainly not least, enter a year: ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjOne}. 'It is going to be a {adjTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjThree}. Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}