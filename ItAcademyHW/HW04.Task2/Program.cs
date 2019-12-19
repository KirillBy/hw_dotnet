using System;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string directionChoice;
            string menuString = "Please choose the direction of moving(or q - to quit):\n\n" +
                                "         w(up) \n" +
                                "a(left)  s(down)  d(right)\n\n";
            Console.WriteLine(menuString);
            directionChoice = Console.ReadLine();
            
            while (directionChoice != "q")
            { 
                switch(directionChoice)
                {
                case "w": 
                    Console.WriteLine("moving forward");
                    break;
                case "s":
                    Console.WriteLine("moving back");
                    break;
                case "a":
                    Console.WriteLine("moving left");
                    break;
                case "d":
                    Console.WriteLine("moving right");
                    break;
                default:
                    Console.WriteLine("unknown command\n"+ menuString);
                    break;
                }
                directionChoice = Console.ReadLine();
            }
 
           
            
        }
    }
}
