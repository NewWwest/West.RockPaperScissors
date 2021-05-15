using System;
using System.Collections.Generic;
using System.Text;
using West.RockPaperScissors.Moves;

namespace West.RockPaperScissors.Strategies
{
    public class HumanInputStrategy : IStrategy
    {
        public Move GetMove(GameState gameState, int playerNumber)
        {
            while (true)
            {
                Console.WriteLine("Enter Move: (P)aper, (R)ock, (S)cissors");
                var move = Console.ReadLine();
                switch (move)
                {
                    case ("P"):
                        return new Paper();
                    case ("S"):
                        return new Scissors();
                    case ("R"):
                        return new Rock();
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}
