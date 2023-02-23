using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;
using System.Collections.Generic;
using System;

namespace GoFish.Tests
{
  [TestClass]
  public class PlayerTests
  {
    [TestMethod]
    public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
    {
      Player newPlayer = new Player("test");
      Assert.AreEqual(typeof(Player), newPlayer.GetType());
      Assert.AreEqual("test", newPlayer.Name);
    }


    [TestMethod]
    public void PairUp_RemovesPairsFromHand_List()
    {
      Player newPlayer = new Player("test");
      Card card1 = new Card("Ace", "Hearts");
      Card card2 = new Card("Ace", "Diamonds");
      Card card3 = new Card("9", "Clubs");
      Card card4 = new Card("9", "Spades");
      Card card5 = new Card("12", "Clubs");
      newPlayer.Hand.Add(card1);
      newPlayer.Hand.Add(card2);
      newPlayer.Hand.Add(card3);
      newPlayer.Hand.Add(card4);
      newPlayer.Hand.Add(card5);
      newPlayer.PairUp();
      Assert.AreEqual(1, newPlayer.Hand.Count);
    }

    [TestMethod]
    public void PairUp_OutputsPairs_List()
    {
      Player newPlayer = new Player("test");
      Card card1 = new Card("Ace", "Hearts");
      Card card2 = new Card("Ace", "Diamonds");
      Card card3 = new Card("9", "Clubs");
      Card card4 = new Card("6", "Spades");
      Card card5 = new Card("12", "Clubs");
      newPlayer.Hand.Add(card1);
      newPlayer.Hand.Add(card2);
      newPlayer.Hand.Add(card3);
      newPlayer.Hand.Add(card4);
      newPlayer.Hand.Add(card5);
      newPlayer.PairUp();
      Assert.AreEqual("   Ace of Hearts", newPlayer.Pairs[0].Item1.ToString());
      Assert.AreEqual("   Ace of Diamonds", newPlayer.Pairs[0].Item2.ToString());
    }

  }
}