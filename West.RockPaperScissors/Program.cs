using West.RockPaperScissors.Strategies;
using West.RockPaperScissors.WinConditions;

namespace West.RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameEngine(new HumanInputStrategy(), new BeatsPreviousChoiceStrategy(), new BestOf3());
            game.Play(true);
        }
    }
}
