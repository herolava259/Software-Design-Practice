

namespace OOPDesign.DeckOfCards;

public class Player
{
    public Player(string playerName)
    {
        PlayerName = playerName;
        deck = new Deck(0);
    }

    private readonly Deck deck;
    public string PlayerName { get; }

    public void AddCard(Card card)
    {
        deck.AddCard(card);
    }
}
