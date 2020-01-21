using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11
{
    class Square : Shapes
    {
        private readonly double _side;
        public Square(int side)
        {
            if (side <= 0)
            {
                Logger.Log.Error("Incorrect income side ( <= 0). It's automaticaly changed to 1 ");
                this._side = 1;
            }
            else
            {
                this._side = side;
            }           
            Logger.Log.Info($"New Square is created with side {_side}.");
        }
        public override double FigureSquare() => _side * _side;
    }
}
