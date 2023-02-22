namespace GoFish.Models;

public class Card
{
  public string Rank { get; }
  public string Suit { get; }
  public int Value { get; }
  public Card(string rank, string suit)
  {
    Rank = rank;
    Suit = suit;
    List<string> faces = new List<string>() { "Jack", "Queen", "King" };
    if (faces.Contains(rank))
    {
      Value = 10;
    }
    else if (rank == "Ace")
    {
      Value = 1;
    }
    else
    {
      Value = int.Parse(rank);
    }
  }
  public override string ToString()
  {
    return $"{Rank,6} of {Suit}";
  }
}


