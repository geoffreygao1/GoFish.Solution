using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;
using System.Collections.Generic;
using System;

namespace GoFish.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("Player 1");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
  }
}