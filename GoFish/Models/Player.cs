namespace GoFish.Models;

public class Player
{
  public string Name { get; set; }
  public int Score { get; set; }
  public List<Card> Hand { get; set; }
  public List<(Card, Card)> Pairs { get; set; }
  public Player(string name)
  {
    Name = name;
    Score = 0;
    Hand = new List<Card>() { };
  }
  public void PairUp()
  {
    List<Card> temp_hand = new List<Card>() { };

    while (Hand.Count > 0)
    {
      Card card_a = Hand[0];
      Hand.RemoveAt(0);
      bool found = false;
      for (int i = 0; i < Hand.Count; i++)
      {
        if (card_a.Rank == Hand[i].Rank)
        {
          Card card_b = Hand[i];
          Hand.RemoveAt(i);
          Pairs.Add((card_a, card_b));
          found = true;
          break;
        }
      }
      if (!found)
      {
        temp_hand.Add(card_a);
      }
    }
    Hand = temp_hand;
    Score = Pairs.Count;
  }
}