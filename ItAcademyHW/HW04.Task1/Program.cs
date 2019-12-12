using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int lastCapLetter = 90;       //Last capital letter ASCII code
            const int firstCapLetter = 65;      ////First capital letter ASCII code
            for (int i = lastCapLetter; i >= firstCapLetter; i--)
            {
                char englCapLetter = (char)i;   //conver ASCII code to capital letter
                char englLowLetter = (char)(i + 32); //conver ASCII code to low letter
                Console.WriteLine(englCapLetter + " " + englLowLetter);
            }
            
        }
    }
}
