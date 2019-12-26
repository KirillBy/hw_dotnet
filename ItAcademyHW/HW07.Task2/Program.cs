using System;
using System.Collections.Generic;

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
        static void Main(string[] args)
        {
            LongestWord("small biggest jsfkdxvksdnf big");
            ChangeMaxAndMinWord("big to small superbigword biggest");
            NumberOfLetters("hi, 56everybody. This is 1 test string -. 3 4 ");
            SortString("hello hi good day super homework");
        }
        static void LongestWord(string entryString) //first method
        {
            if (!string.IsNullOrEmpty(entryString))
            {
                string[] separators = { " " };
                string[] words = entryString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string maxWord = words[0]; //to keep biggest word
                foreach (var word in words)  // finding most longest word
                {
                    if (maxWord.Length < word.Length)
                        maxWord = word;
                }
                maxWord = string.Concat(maxWord, " "); // here I add a spacing to delete it with spacing
                entryString  = entryString.Replace(maxWord, null); // my point of view how to delete word from string
                Console.WriteLine(entryString);
            } 
            else
                Console.WriteLine("Error. String is empty");
        }
        static void ChangeMaxAndMinWord(string entryString) //second method
        {
            if (!string.IsNullOrEmpty(entryString))
            {
                string[] separators = { " " };
                string[] words = entryString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string maxWord = words[0]; //to keep longest word
                string minWord = words[0]; //to keep most small word
                foreach (var word in words)  // finding longest and most short word
                {
                    if (maxWord.Length < word.Length)
                        maxWord = word;
                    if (minWord.Length > word.Length)
                        minWord = word;
                }
                for (int i = 0; i < words.Length; i++)  // finding most longest word
                {
                    if (words[i] == maxWord)
                    { words[i] = minWord; }
                    else if (words[i] == minWord)
                    { words[i] = maxWord; }
                }
                entryString = null;  // make our main string empty
                for (int i = 0; i < words.Length; i++)  // remake main string with changing max and min word 
                {
                    entryString = string.Concat(entryString, words[i], " ");
                }
                Console.WriteLine(entryString);
            }
            else
                Console.WriteLine("Error. String is empty");
        }
        static void NumberOfLetters(string entryString) //third method
        {
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
        static void SortString(string entryString) //fourth method
        {
            if (!string.IsNullOrEmpty(entryString))
            {
                string[] separators = { " " };
                string[] words = entryString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                Array.Sort(  words, new Comp() ); //sorting our array
                
                foreach (var word in words) // display array
                {
                    Console.WriteLine(word + " ");
                }
            }

        }
    }
}
