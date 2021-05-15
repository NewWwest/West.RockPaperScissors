using System;
using System.Collections.Generic;
using System.Text;

namespace West.RockPaperScissors.WinConditions
{
    public interface IWinCondition
    {
        int? GetWinner(GameState gameState); 
    }
}
