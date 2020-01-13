using System;

namespace HW07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Enter a poem, separating it rows by \";\": ");
            string[] separators = { ";" };  
            string poem = Console.ReadLine();
            poem = poem.Replace('O', 'A').Replace('o', 'a');
            string[] rows = poem.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var row in rows)
                Console.WriteLine(row);
        }
    }
}
