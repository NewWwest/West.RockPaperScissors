using System;
using System.Collections.Generic;
using West.RockPaperScissors.Moves;
using West.RockPaperScissors.Strategies;
using West.RockPaperScissors.WinConditions;

namespace West.RockPaperScissors
{
    public class GameEngine
    {
        private readonly IStrategy _player1Strategy;
        private readonly IStrategy _player2Strategy;
        private readonly IWinCondition _winCondition;

        public GameEngine(IStrategy player1Strategy, IStrategy player2Strategy, IWinCondition winCondition)
        {
            _player1Strategy = player1Strategy;
            _player2Strategy = player2Strategy;
            _winCondition = winCondition;
        }

        public int Play(bool verbose)
        {
            var gameState = new GameState();
            gameState.Moves = new List<List<Move>>(2) { new List<Move>(), new List<Move>() };
            gameState.Scores = new List<int>(2) { 0, 0 };

            while (true)
            {
                Move move0 = _player1Strategy.GetMove(gameState, 0);
                Move move1 = _player2Strategy.GetMove(gameState, 1);
                RoundResult result = move0.DelegateHandle(move1);
                if (verbose)
                {
                    Console.WriteLine($"Player 0 played {move0.GetType()}");
                    Console.WriteLine($"Player 1 played {move1.GetType()}");
                }
                if (!result.Win.HasValue)
                {
                    if (verbose)
                    {
                        Console.WriteLine("Draw");
                    }
                }
                else if (result.Win.Value)
                {
                    gameState.Scores[1]++;
                    if (verbose)
                    {
                        Console.WriteLine("Player 1 wins round");
                    }
                }
                else
                {
                    gameState.Scores[0]++;
                    if (verbose)
                    {
                        Console.WriteLine("Player 0 wins round");
                    }
                }
                gameState.Moves[0].Add(move0);
                gameState.Moves[1].Add(move1);

                var winner = _winCondition.GetWinner(gameState);
                if (winner.HasValue)
                {
                    if (verbose)
                    {
                        Console.WriteLine($"Player {winner.Value} wins game.");
                    }
                    return winner.Value;
                }
            }

        }
    }
}
