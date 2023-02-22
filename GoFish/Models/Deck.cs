namespace GoFish.Models;
using System.Collections.Generic;
using System.Linq;

public class Deck
{
  public List<Card> Cards = new List<Card>() { };
  public Deck()
  {
    List<string> suits = new List<string>() { "Diamonds", "Clubs", "Hearts", "Spades" };
    foreach (string suit in suits)
    {
      IEnumerable<int> ranks = Enumerable.Range(2, 9);
      foreach (int rank in ranks)
      {
        Cards.Add(new Card(rank.ToString(), suit));
      }
      List<string> faces = new List<string>() { "Jack", "Queen", "King", "Ace" };
      foreach (string face in faces)
      {
        Cards.Add(new Card(face, suit));
      }
    }
  }
  public void Shuffle()
  {
    for (int i = 0; i < Cards.Count; i++)
    {
      Random rnd = new Random();
      int j = rnd.Next(i, Cards.Count);
      Card temp_1 = Cards[i];
      Card temp_2 = Cards[j];
      Cards[i] = temp_2;
      Cards[j] = temp_1;
    }
  }
}