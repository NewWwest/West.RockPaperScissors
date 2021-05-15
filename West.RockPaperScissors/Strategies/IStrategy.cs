using System;
using System.Collections.Generic;
using System.Text;
using West.RockPaperScissors.Moves;

namespace West.RockPaperScissors.Strategies
{
    public interface IStrategy
    {
        Move GetMove(GameState gameState, int playerNumber);
    }
}
