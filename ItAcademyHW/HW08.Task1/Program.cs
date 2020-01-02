using System;
using System.Text;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder inputString = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?");
            StringBuilder firstPart = new StringBuilder(); 
            StringBuilder secondPart = new StringBuilder();
            StringBuilder temp = new StringBuilder();
            for (int i = 0;inputString[i] != '?' && i < inputString.Length; i++) // separate input string into 2 parts
            {
                if (inputString[i] != '!' && inputString[i] != '.')
                { firstPart.Append(inputString[i]); }       // first part with changes
                temp.Append(inputString[i]);                // first part without changes
            }
            secondPart = inputString.Remove(0, temp.Length); // second part without changes
            secondPart.Replace(' ', '_');                     // second part with changes
            StringBuilder finalString = new StringBuilder(); 
            finalString.Append(firstPart).Append(secondPart); // final string
            Console.WriteLine(finalString);
        }
    }
}
