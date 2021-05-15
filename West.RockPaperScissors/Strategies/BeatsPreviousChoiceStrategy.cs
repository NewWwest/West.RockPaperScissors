using System.Linq;
using West.RockPaperScissors.Moves;

namespace West.RockPaperScissors.Strategies
{
    public class BeatsPreviousChoiceStrategy : IStrategy
    {
        private readonly RandomStrategy _randomStrategy;

        public BeatsPreviousChoiceStrategy()
        {
            _randomStrategy = new RandomStrategy();
        }

        public Move GetMove(GameState gameState, int playerNumber)
        {
            if (!gameState.Moves[playerNumber].Any())
            {
                return _randomStrategy.GetMove(gameState, playerNumber);            
            }

            var prevMove = gameState.Moves[playerNumber].Last();
            if(prevMove.GetType() == typeof(Paper))
            {
                return new Scissors();
            }
            if (prevMove.GetType() == typeof(Rock))
            {
                return new Paper();
            }
            if (prevMove.GetType() == typeof(Scissors))
            {
                return new Rock();
            }
            return _randomStrategy.GetMove(gameState, playerNumber);
        }
    }
}
