using System;
using System.Diagnostics;
namespace HW06.Task3
{
    class Program
    {
        const int arraySize = 100_000_000;
       
        static void Main(string[] args)
        { 
            Stopwatch timer = new Stopwatch();
            long[] array1 = new long[arraySize];
            var rand = new Random();
            Console.WriteLine("TOTAL AMOUNT OF NUMBER IN ARRAY: " + arraySize);
            //////////
            Console.WriteLine("Array filling with random numbers started. Please wait...");
            for (int i = 0; i < arraySize; i++) //create array and fill it with random numbers
            {
                array1[i] = rand.Next(1001);
            }
            Console.Write("Array filling with random numbers finished");

            //for (int i = 0; i < arraySize; i++) //display array
            //{
            //    if ((i % 20) == 0)
            //        Console.Write("\n");
            //    Console.Write(array1[i] + " ");
            //}
            Console.Write("\n\n");

            //////////
            Console.WriteLine("Reversing by user methods started. Please wait...");
            timer.Start();
            for (int i = 0; i < arraySize / 2; i++) // reverse array by user method
            {
                long firstElem = array1[i];
                long lastElem = array1[arraySize - 1 - i];
                array1[i] = lastElem;
                array1[arraySize - 1 - i] = firstElem;
            }
            timer.Stop();
            TimeSpan userMethodTime = timer.Elapsed;
            Console.Write("User method time: " + userMethodTime.TotalMilliseconds);

            //for (int i = 0; i < arraySize; i++) //display array
            //{
            //    if ((i % 20) == 0)
            //        Console.Write("\n");
            //    Console.Write(array1[i] + " ");
            //}
            Console.Write("\n\n");

            ///////////
            Console.WriteLine("Reversing by Array.Reverse() method started. Please wait...");
            timer.Start();
            Array.Reverse(array1); // reverse array by .Net method
            timer.Stop();
            TimeSpan dotNetMethodTime = timer.Elapsed;
            Console.Write("Array.Reverse() time: " + dotNetMethodTime.TotalMilliseconds);

            //for (int i = 0; i < arraySize; i++) //display array
            //{
            //    if ((i % 20) == 0)
            //        Console.Write("\n");
            //    Console.Write(array1[i] + " ");
            //}
            Console.Write("\n\n");
        }
    }
}
