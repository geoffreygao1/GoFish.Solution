using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;
using System.Collections.Generic;
using System;

namespace GoFish.Tests
{
  [TestClass]
  public class CardTests
  {
    [TestMethod]
    public void CardConstructor_CreatesInstanceOfCard_Card()
    {
      Card newCard = new Card("Ace", "Spades");
      Assert.AreEqual(typeof(Card), newCard.GetType());
    }
    [TestMethod]
    public void CardConstructor_CreatesSuitPropertyOfCard_String()
    {
      Card newCard = new Card("Ace", "Spades");
      Assert.AreEqual("Spades", newCard.Suit);
    }
    [TestMethod]
    public void CardConstructor_CreatesRankPropertyOfCard_String()
    {
      Card newCard = new Card("Ace", "Spades");
      Assert.AreEqual("Ace", newCard.Rank);
    }

    [TestMethod]
    public void CardConstructor_CreatesValuePropertyOfCard_String()
    {
      Card newCard = new Card("Ace", "Spades");
      Assert.AreEqual(1, newCard.Value);
    }

    [TestMethod]
    public void ToString_ReturnsStringValueOfCard_String()
    {
      Card newCard = new Card("Ace", "Spades");
      Assert.AreEqual("   Ace of Spades", newCard.ToString());
    }
  }
}