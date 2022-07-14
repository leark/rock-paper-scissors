using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RPSTests
  {
    [TestMethod]
    public void PlayRPS_ReturnsDrawIfSameHand_Draw()
    {
      Assert.AreEqual("Draw", RPS.PlayRPS("paper", "paper"));
    }

    [TestMethod]
    public void PlayRPS_ReturnsPlayerThatPlayedRockAgainstScissors_Player1()
    {
      Assert.AreEqual("Player 1", RPS.PlayRPS("rock", "scissors"));
    }

    [TestMethod]
    public void PlayRPS_ReturnsPlayerThatPlayedScissorsAgainstPaper_Player2()
    {
      Assert.AreEqual("Player 2", RPS.PlayRPS("paper", "scissors"));
    }

    [TestMethod]
    public void PlayRPS_ReturnsPlayerThatPlayedPaperAgainstRock_Player1()
    {
      Assert.AreEqual("Player 1", RPS.PlayRPS("paper", "rock"));
    }
  }
}

