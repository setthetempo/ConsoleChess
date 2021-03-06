﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    class Knight : Piece
    {
        public Knight(bool isBlack) : base(isBlack)
        {
            this.appearance = '&';
        }

        public override bool isLegalMove(Tuple<int, int> origin, Tuple<int, int> destination, bool capturing)
        {
            if(Math.Abs(destination.Item1 - origin.Item1) == 2 && Math.Abs(destination.Item2 - origin.Item2) == 1
                || Math.Abs(destination.Item1 - origin.Item1) == 1 && Math.Abs(destination.Item2 - origin.Item2) == 2)
            {
                return true;
            }

            return false;
        }
    }
}
