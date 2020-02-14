using System;
using System.Collections.Generic;
using System.Text;

namespace RegularBallSuperBall
{
    class Ball
    {
        public string ballType { get; set; }

        public Ball(string ballType)
        {
            this.ballType = ballType;
        }
        public Ball()
        {
            this.ballType = "regular";
        }
    }
}
