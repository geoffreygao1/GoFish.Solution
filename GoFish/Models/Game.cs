namespace GoFish.Models;
using System.Collections.Generic;
using System.Linq;

public class Game
{
  public List<Player> Players = new List<Player>() { };
  private int _turnCounter = 0;
  public Deck gameDeck { get; set; }

  public Game(string userName)
  {
    // new deck
    gameDeck = new Deck();
    gameDeck.Shuffle();

    // new player
    Player user = new Player(userName);
    Players.Add(user);

    // cpu player
    Player cpu = new Player("computer");
    Players.Add(cpu);

    // deal to players? or deal method? or draw method repeated?
    for (int i = 0; i < 5; i++)
    {
      foreach (Player x in Players)
      {
        DrawCard(x);
      }
    }
    // Pair up on initial hand
    foreach (Player x in Players)
    {
      x.PairUp();
    }
  }

  public void GuessCard(string cardGuess)
  {
    bool found = false;
    Player currentPlayer = Players[(_turnCounter) % Players.Count];
    List<Player> targetPlayers = Players.Where(x => x.Name != currentPlayer.Name).ToList();
    foreach (Player targetPlayer in targetPlayers)
    {
      foreach (Card x in targetPlayer.Hand)
      {
        if (x.Rank == cardGuess)
        {
          Players[(_turnCounter) % Players.Count].Hand.Add(x);
          targetPlayer.Hand.Remove(x);
          currentPlayer.PairUp();
          found = true;
          break;
        }
      }
    }
    if (!found)
    {
      _turnCounter++;
    }
  }
  public void DrawCard(Player player)
  {
    player.Hand.Add(gameDeck.Cards[0]);
    gameDeck.Cards.RemoveAt(0);
  }



}