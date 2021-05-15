using System;
using System.Collections.Generic;
using System.Text;

namespace West.RockPaperScissors.Moves
{
    public abstract class Move
    {
        public abstract RoundResult DelegateHandle(Move move);
        public abstract RoundResult Handle(Paper move);
        public abstract RoundResult Handle(Rock move);
        public abstract RoundResult Handle(Scissors move);
    }
}
