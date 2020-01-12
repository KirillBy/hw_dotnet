using System;

namespace HW06.Task2
{
    class Program
    {
        const int arraySize = 5;
        static void Main(string[] args)
        {
            int[] array1 = new int[arraySize];
            int arrayLastNumber;
            int lastNumberPosicion;

            for (int i = 0; i < (arraySize-1); i++)  //fill the massive with numbers frim console
            {
                Console.WriteLine("Enter " + (i + 1) + " number -> ");
                Int32.TryParse(Console.ReadLine(), out array1[i]); 
            }

            Console.WriteLine("Enter the  last number to put in array ->"); // get last number
            Int32.TryParse(Console.ReadLine(), out arrayLastNumber);

            Console.WriteLine("Enter the  position to put this number in array(from 1 to " + arraySize + ") ->");
            Int32.TryParse(Console.ReadLine(), out lastNumberPosicion);        //get position of last number
            if ((lastNumberPosicion > arraySize) || (lastNumberPosicion < 1))    //check out if the number is in array scope
            {
                Console.WriteLine("Error!!!! Our of array range!!! Be careful.....");
                return;
            }

            Console.WriteLine("\n\n\n");

            for(int i = (lastNumberPosicion-1); i < arraySize; i++) // putting user number to it's possition
            {
                int tempNumber = array1[i];
                array1[i] = arrayLastNumber;
                arrayLastNumber = tempNumber;
            }

            for (int i = 0; i < arraySize; i++) //display
            {
                Console.WriteLine("Number " + (i + 1) + " is " + array1[i]);
                Console.WriteLine("\n******************************\n");
            }
        }
    }
}
