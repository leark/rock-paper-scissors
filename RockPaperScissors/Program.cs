using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("What is your hand? (rock, paper, scissors)");
      string player1 = Console.ReadLine();
      Random r = new Random();
      // get random number between 0, 1, 2
      int aiHand = r.Next(3);
      string[] possibleHands = {"rock", "paper", "scissors"};
      string result = RPS.PlayRPS(player1, possibleHands[aiHand]);
      if (result == "Player 1")
      {
        Console.WriteLine("Player wins this time.");
      }
      else if (result == "Player 2")
      {
        Console.WriteLine("AI wins this time.");
      }
      else if (result == "Draw")
      {
        Console.WriteLine("It was a draw!");
      } 
      else
      {
        Console.WriteLine(result);
      }

      Console.WriteLine("Player's Hand: " + player1);
      Console.WriteLine("AI's Hand: " + possibleHands[aiHand]);
      Console.WriteLine("Play again? (y/n)");
      if (Console.ReadLine() == "y")
      {
        Main();
      }
    }
  }
}