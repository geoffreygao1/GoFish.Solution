using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;
using System.Collections.Generic;
using System;

namespace GoFish.Tests
{
  [TestClass]
  public class DeckTests
  {
    [TestMethod]
    public void DeckConstructor_CreatesInstanceOfDeck_Deck()
    {
      Deck newDeck = new Deck();
      Assert.AreEqual(typeof(Deck), newDeck.GetType());
    }

    [TestMethod]
    public void DeckConstructor_Creates52CardsInDeck_Int()
    {
      Deck newDeck = new Deck();
      Assert.AreEqual(52, newDeck.Cards.Count);
    }

    [TestMethod]
    public void Shuffle_RearrangesOrderOfCardList_Void()
    {
      Deck newDeck = new Deck();
      //Card testCard = new Card("2", "Diamonds");
      Card testCard = newDeck.Cards[0];
      Assert.AreEqual(testCard.ToString(), newDeck.Cards[0].ToString());
      newDeck.Shuffle();
      Assert.AreNotEqual(testCard.ToString(), newDeck.Cards[0].ToString());
    }

  }
}