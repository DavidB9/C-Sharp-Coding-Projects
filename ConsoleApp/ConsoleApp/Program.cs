using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //A one-dimensional array of strings.
            string[] myStrings = { "David", "Cian", "Eileen", "Alan", "Pauline", "Leanne", "Michael" };

            //Asks the user for input
            Console.WriteLine("Please enter some text");
            //saves inputted text as a string
            string newText = Console.ReadLine();

            //iterates through the array adding the inputted text onto each element in the array
            for (int i = 0; i < myStrings.Length; i++)
            {
                myStrings[i] = myStrings[i] + " " + newText;
            }

            //iterates through the array and prints its elements to the console
            for (int j = 0; j < myStrings.Length; j++)
            {
                Console.WriteLine(myStrings[j]);
            }

            //infinite loop that constantly prints to screen
            int count = 0;
            while (true)
            {
                count++;
                Console.WriteLine("This loops infintely");
                //stops the infinite loop
                if (count > 15)
                {
                    break;
                }
            }

            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            for (int index = 0; index <= 5; index++)
            {
                Console.WriteLine(index);
            }


            //A list of strings where each item in the list is unique.
            List<string> names = new List<string>();
            names.Add("Tom");
            names.Add("Sam");
            names.Add("Jesse");
            names.Add("Sean");
            names.Add("Anne");

            //Ask the user to input text to search for in the list.
            Console.WriteLine("Please enter a name to see if it is in the list");
            string name = Console.ReadLine();

            //A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
            for (int x = 0; x < names.Count; x++)
            {
                if (names[x] == name)
                {
                    Console.WriteLine("The name entered is at " + x + " index in the list");
                    //stops loop when match has been found
                    break;
                }
                //tells a user if they put in text that isn’t in the list.
                else if (names[x] != name && x == names.Count - 1)
                {
                    Console.WriteLine("You input text that isn't in the list");
                }
            }


            //A list of strings that has at least two identical strings in the list.
            List<string> words = new List<string>();
            words.Add("Ham");
            words.Add("Sea");
            words.Add("School");
            words.Add("Bag");
            words.Add("TV");
            words.Add("Console");
            words.Add("Copy");
            words.Add("Sea");

            //Ask the user to select text to search for in the list.
            Console.WriteLine("Please enter a word to see if it is in the list");
            string word = Console.ReadLine();

            //loop that iterates through the list and then displays the indices of the list
            //that contain matching text on the screen.
            for (int y = 0; y < words.Count; y++)
            {
                if (words[y] == word)
                {
                    Console.WriteLine("The word entered is at " + y + " index in the list");
                }
                //tells a user if they put in text that isn’t in the list.
                else if (words[y] != word && y == words.Count - 1)
                {
                    Console.WriteLine("You input text that isn't in the list");
                }
            }


            //list of strings that has at least two identical strings in the list.
            List<string> places = new List<string>();
            places.Add("Portarlington");
            places.Add("Naas");
            places.Add("Portlaoise");
            places.Add("Tullamore");
            places.Add("Naas");

            //list to contain the strings that have already appeared in the foreach loop
            List<string> appeared = new List<string>();

            //Create a foreach loop that evaluates each item in the list
            foreach (string place in places)
            {
                //check if appeared list contains the string being evaluated
                if(!appeared.Contains(place))
                {
                    Console.WriteLine(place + " has not appeared");
                    //add to appeared list 
                    appeared.Add(place);
                }
                //if the string being evalutaed has already appeared
                else if(appeared.Contains(place))
                {
                    Console.WriteLine(place + " has already appeared");
                }

            }

            Console.Read();

        }
    }
}
