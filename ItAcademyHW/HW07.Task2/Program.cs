using System;
using System.Collections.Generic;
using System.Text;
namespace HW07.Task2
{
    class Comp : IComparer<string>  //special compare class for task 2.4
    {
        public int Compare(string a, string b)
        {
            if (a.Length == b.Length) return 0;
            return a.Length > b.Length ? -1 : 1;
        }
    }
    class Program
    {
        const string inputString = "abc Lorem ipsum qwe cansectetur dolor sit qwertyuiopa amet, consectetur adipiscing asdfghjklzx elit. zxcvbnmasde iuytrgfhdew";
        static void Main(string[] args)
        {
            Console.WriteLine("Original string: " + inputString);
            Console.WriteLine("\n\n");
            Console.WriteLine("First task----------------------------------");
            LongestWord(inputString);
            Console.WriteLine("\n\n");
            Console.WriteLine("Second task---------------------------------");
            ChangeMaxAndMinWord(inputString);
            Console.WriteLine("\n\n");
            Console.WriteLine("Third task----------------------------------");
            NumberOfLetters(inputString);
            Console.WriteLine("\n\n");
            Console.WriteLine("Fourth task---------------------------------");
            SortString(inputString);
            Console.WriteLine("\n\n");
        }
        static void LongestWord(string inputString) //first task method
        {
            String entryString = new String(inputString);
            if (!string.IsNullOrEmpty(entryString))
            {           
                string[] separators = { " " };
                string[] words = entryString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                List<string> longestWords =  FindLongestWords(words);
                StringBuilder mergedString = new StringBuilder(null);  // make our main string empty
                for (int i = 0; i < words.Length; i++)  // fill new string excepting longest words 
                {
                    if (!longestWords.Contains(words[i]))
                        mergedString = mergedString.Append(words[i]).Append(" ");
                }
                string outPutString = mergedString.ToString();
                Console.WriteLine("String without largest word: " + outPutString);
            } 
            else
                Console.WriteLine("Error. String is empty");
        }
        static void ChangeMaxAndMinWord(string inputString) //second task method
        {
            String entryString = new String(inputString);
            if (!string.IsNullOrEmpty(entryString))
            {
                string[] separators = { " " };
                string[] words = entryString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                List<string> longestWords = FindLongestWords(words);
                List<string> shortestWords = FindShortestWords(words);
                StringBuilder mergedString = new StringBuilder(null);  // make our main string empty
                int shortwordsCounter = 0;
                int longwordsCounter = 0;
                for (int i = 0; i < words.Length; i++)  // fill new string changing longest and shortest words 
                {
                    if (!(longestWords.Contains(words[i]) || shortestWords.Contains(words[i]))) //if word isn't short or long append it to new string
                    {
                        mergedString = mergedString.Append(words[i]).Append(" ");
                    }
                    else if ((longestWords.Contains(words[i])) && (shortwordsCounter+1) < shortestWords.Count) // if word is one of longest put shortest instead of it 
                    {                                                                                          // and move pointer to the next short word in container
                        mergedString = mergedString.Append(shortestWords[shortwordsCounter]).Append(" ");      
                        shortwordsCounter++;
                    }
                    else if ((longestWords.Contains(words[i])) && (shortwordsCounter+1) >= shortestWords.Count) // if all shortest word in container is already used, put the last one
                    {                                                                                           // to our new string
                        mergedString = mergedString.Append(shortestWords[shortwordsCounter]).Append(" ");
                    }
                    else if ((shortestWords.Contains(words[i])) && (longwordsCounter + 1) < longestWords.Count) //the same but for the shortest
                    {
                        mergedString = mergedString.Append(longestWords[longwordsCounter]).Append(" ");
                        longwordsCounter++;
                    }
                    else if ((shortestWords.Contains(words[i])) && (longwordsCounter + 1) >= longestWords.Count)
                    {
                        mergedString = mergedString.Append(longestWords[longwordsCounter]).Append(" ");
                    }
                }
                string outPutString = mergedString.ToString();
                Console.WriteLine("String with changed Largest and Shortest: " + outPutString);
            }
            else
                Console.WriteLine("Error. String is empty");
        }
        static void NumberOfLetters(string inputString) //third task method
        {
            String entryString = new String(inputString);
            if (!string.IsNullOrEmpty(entryString))
            {
               
                int counterLetters = 0; int counterDigits = 0; int counterPunctuation = 0;
                char[] symbols = entryString.ToCharArray();
                foreach (var symbol in symbols)
                {
                    if (char.IsLetter(symbol))
                        counterLetters++;
                    if (char.IsDigit(symbol))
                        counterDigits++;
                    if (char.IsPunctuation(symbol))
                        counterPunctuation++;
                }
                Console.WriteLine($"There are {counterLetters} letters, {counterDigits} digits, {counterPunctuation}" +
                    $" punktuations marks in our string");
            }
        } 
        static void SortString(string inputString) //fourth task method
        {
            String entryString = new String(inputString);
            if (!string.IsNullOrEmpty(entryString))
            {
                string[] separators = { " " };
                string[] words = entryString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                Array.Sort(words, new Comp() ); //sorting our array

                Console.Write("Sorted string: ");
                foreach (var word in words) // display array
                {
                    Console.Write(word + " ");
                }
            }

        }
        static List<string> FindLongestWords(string[] words) //method to find longest word in array
        {
            string maxWord = new string(words[0]); //to keep biggest word
            foreach (var word in words)  // finding one of the longest word
            {
                if (maxWord.Length < word.Length)
                    maxWord = word;
            }
            int maxLength = maxWord.Length; //getting length of the longest word
            List<string> maxWordsArray = new List<string>(); //List for longest words
            foreach (var word in words)  // putting all longest words to the list
            {
                if (maxLength == word.Length)
                { maxWordsArray.Add(word); }
            }
            return maxWordsArray; // returning List with all longest words
        }
        static List<string> FindShortestWords(string[] words) //method to find shortes word in array
        {
            string minWord = new string(words[0]); //to keep shortes word
            foreach (var word in words)  // finding one of the shortest word
            {
                if (minWord.Length > word.Length)
                    minWord = word;
            }
            int minLength = minWord.Length; //getting length of the shortest word
            List<string> minWordsArray = new List<string>(); //List for shortest words
            foreach (var word in words)  // putting all shortest words to the list
            {
                if (minLength == word.Length)
                { minWordsArray.Add(word); }
            }
            return minWordsArray; // returning List with all shortest words
        }
    }
}
