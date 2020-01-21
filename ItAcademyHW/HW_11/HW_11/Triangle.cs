using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11
{
    class Triangle : Shapes
    {
        private readonly double _ab;
        private readonly double _bc;
        private readonly double _ca;

        public Triangle(double ab, double bc, double ca)
        {
            if (ab <= 0 || bc <= 0 || ca <= 0)
            {
                Logger.Log.Error("Incorrect income sides ( <= 0). It's automaticaly changed to 1 ");
                 this._ab = 1;
                 this._bc = 1;
                 this._ca = 1;
            }
            else
            {
                this._ab = ab;
                this._bc = bc;
                this._ca = ca;
            }
           
            Logger.Log.Info($"New Triangle is created with sides {_ab}, {_bc}, {_ca}.");
        }
        public override double FigureSquare()
        {
            double halfPer = (_ab + _bc + _ca) / 2;
            return Math.Sqrt(halfPer * (halfPer - _ab) * (halfPer - _bc) * (halfPer - _ca));
        }
    }
}
