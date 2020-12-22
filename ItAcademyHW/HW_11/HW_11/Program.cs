using System;
using System.Collections.Generic;

namespace HW_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info($"Programm {System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName} has been started");
            List<Shapes> figures = new List<Shapes>();
            for (int i = 0; i <= 10; i++)
            {
                figures.Add(new Square(i));
                figures.Add(new Triangle(i, i, i));
                figures.Add(new Circle(i));
            }
            foreach (var item in figures)
            {
                Console.WriteLine($"This is {item.GetType().Name.ToString()}." +
                        $" It's CLR Type is {item.GetType().ToString()}. " +
                        $" It's square is {item.FigureSquare()}");
                if(item is Circle)
                Console.WriteLine("---------------------------------------------");
            }
            Logger.Log.Info("Programm has been finished");
        }

    }
}
