using System;
using System.Collections.Generic;
using System.Text;

namespace West.RockPaperScissors.Moves
{
    public class Rock : Move
    {
        public override RoundResult DelegateHandle(Move move)
        {
            return move.Handle(this);
        }

        public override RoundResult Handle(Paper move)
        {
            return new RoundResult()
            {
                Win = false
            };
        }

        public override RoundResult Handle(Rock move)
        {
            return new RoundResult()
            {
                Win = null
            };
        }

        public override RoundResult Handle(Scissors move)
        {
            return new RoundResult()
            {
                Win = true
            };
        }
    }
}
