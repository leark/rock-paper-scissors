using System.Collections.Generic;
using System;

namespace RockPaperScissors.Models
{
  public class RPS
  {
    public static string PlayRPS(string player1, string player2)
    {
      // first lowercase the inputs
      player1 = player1.ToLower();
      player2 = player2.ToLower();
      string[] possibleHands = {"rock", "paper", "scissors"};

      // check if hands from both players are allowed
      if (Array.Exists(possibleHands, element => element == player1) && Array.Exists(possibleHands, element => element == player2))
      {
        // if they're same
        if (player1 == player2)
        {
          return "Draw";
        }
        
        // create a dictionary of hands with hands(key) to players(value)
        Dictionary<string, string> hands = new Dictionary<string, string> { {player1, "Player 1"}, {player2, "Player 2"}};
        // if hands contain rock and scissors
        if (hands.ContainsKey("rock") && hands.ContainsKey("scissors"))
        {
          // return player who played rock
          return hands["rock"];
        }
        else if (hands.ContainsKey("paper") && hands.ContainsKey("scissors"))
        {
          return hands["scissors"];
        }
        else if (hands.ContainsKey("paper") && hands.ContainsKey("rock"))
        {
          return hands["paper"];
        }
        return "Unknown Result";
      }
      else
      {
        // if players decided to play something other than rock paper or scissors
        return "Please play rock, paper or scissors.";
      }
    }
  }
}