using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace QuantumGoFish;

public class QGoFish
{
    private readonly string[] players;
    private readonly Dictionary<string, string[]> playerCards = new();
    private readonly List<string> suits = new();
    private string currentPlayer;
    public QGoFish(params string[] players)
    {
        this.players = players;
        currentPlayer = players.First();
        foreach (var player in players)
        {
            playerCards.Add(player, new[] {"???", "???", "???", "???"});
        }
    }
    public ReadOnlyCollection<string> Players => playerCards.Keys.ToList().AsReadOnly();
    public ReadOnlyCollection<string> Suits => suits.AsReadOnly();
    public ReadOnlyCollection<string> CardsFor(string player)
    {
        return playerCards[player].ToList().AsReadOnly();
    }
    public void DoYouHave(string askee, string suit)
    {
        
        Console.WriteLine($"{currentPlayer} asks {askee}, 'Do you have any {suit}s?'");

        suits.Add($"{suit}s");
        playerCards[currentPlayer][0] = suit;
        SetNextPlayer();
    }
    private void SetNextPlayer()
    {
        var currentPlayerIndex = Array.IndexOf(players, currentPlayer);
        currentPlayer = players[(currentPlayerIndex+1) % players.Length];
    }
    public string CurrentPlayer => currentPlayer;
}
