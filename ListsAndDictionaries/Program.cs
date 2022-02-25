using System;
using System.Collections.Generic;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();

            Console.WriteLine("\n\n=============================================\n\n");

            ProblemTwo();
        }

        //Problem 1.
        static void ProblemOne()
        {
            List<string> names = new List<string>();
            string userInput;

            do
            {
                Console.WriteLine("Please enter a friend's name or \"ok\" to quit:");
                userInput = Console.ReadLine();
                if (userInput != "ok")
                {
                    names.Add(userInput);
                }
            } while (userInput != "ok");

            if (names.Count > 0) //Display likes notification message if user entered at least one name
            {
                if (names.Count == 1)
                {
                    Console.WriteLine(names[0] + " likes your post.");
                }
                else if (names.Count == 2)
                {
                    Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
                }
                else
                {
                    Console.WriteLine(names[0] + ", " + names[1] + ", and " + (names.Count - 2) + " others like your post."); 
                }

            }
            else //Display no notifications message if user didn't enter any names
            {
                Console.WriteLine("0 Notifications.");
            }

        }

        //Problem 2.
        static void ProblemTwo()
        {
            Dictionary<char, int> uniqueLetters = new Dictionary<char, int>();

            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            //Iterate through each character in the users sentence
            foreach (char i in sentence)
            {
                if (uniqueLetters.ContainsKey(i)) //increment the character key's value for each duplicate found
                {
                    ++uniqueLetters[i];
                }
                else //otherwise, add character key to dictionary with value of 1 
                {
                    uniqueLetters.Add(i, 1);
                }
            }

            uniqueLetters.Remove(' '); //Remove space character from the dictionary

            foreach (KeyValuePair<char, int> kvp in uniqueLetters)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }
        }
    }
}