using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11
{
    class Circle : Shapes
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            if(radius <= 0 )
            {
                Logger.Log.Error("Incorrect income radius ( <= 0). It's automaticaly changed to 1 ");
                this._radius = 1;
            }            
            else
            {
                this._radius = radius;
            }           
            Logger.Log.Info($"New Circle is created with radius {_radius}.");
        }
        public override double FigureSquare() => Math.PI * _radius * _radius;
    }
}
