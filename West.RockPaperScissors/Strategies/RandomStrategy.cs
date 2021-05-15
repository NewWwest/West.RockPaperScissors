using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using West.RockPaperScissors.Moves;
using West.RockPaperScissors.Utils;

namespace West.RockPaperScissors.Strategies
{
    public class RandomStrategy : IStrategy
    {
        private readonly Random rand = new Random();
        private readonly List<Type> possibleMoveTypes = new List<Type>(); 

        public RandomStrategy()
        {
            possibleMoveTypes = ReflectionUtils.GetEnumerableOfType<Move>().ToList();
        }

        public Move GetMove(GameState gameState, int playerNumber)
        {
            var moveType = possibleMoveTypes[rand.Next(0, possibleMoveTypes.Count)];
            return ReflectionUtils.Activate<Move>(moveType);
        }
    }
}
