using System;

namespace HW06.Task1
{
    class Program
    {
        const int arraySize = 10;
        static void Main(string[] args)
        {
            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];
            int[] array3 = new int[arraySize];

            var rand = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                array1[i] = rand.Next(1001);  //first random number
                Console.WriteLine("Enter " + (i + 1) + " number -> ");
                Int32.TryParse(Console.ReadLine(), out array2[i]); //second number from console
                array3[i] = array1[i] + array2[i]; // third number = first + second
            }

            Console.WriteLine("\n\n\n");

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("First number(random) " + (i+1) + " element is " + array1[i]);
                Console.WriteLine ("Second number(user choice) " + (i+1) + " element is " + array2[i]);
                Console.WriteLine("Third number(first + second) " + (i+1) + " element is " + array3[i]);
                Console.WriteLine("\n******************************\n");
            }
        }
    }
}
