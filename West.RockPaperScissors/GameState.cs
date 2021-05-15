using System;
using System.Collections.Generic;
using West.RockPaperScissors.Moves;

namespace West.RockPaperScissors
{
    public class GameState
    {
        public List<List<Move>> Moves { get; set; }

        public List<int> Scores { get; set; }
    }
}
