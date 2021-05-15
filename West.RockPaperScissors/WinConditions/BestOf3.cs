using System;
using System.Collections.Generic;
using System.Text;

namespace West.RockPaperScissors.WinConditions
{
    public class BestOf3 : IWinCondition
    {
        public int? GetWinner(GameState gameState)
        {
            for (int i = 0; i < gameState.Scores.Count; i++)
            {
                if (gameState.Scores[i] >= 2)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
