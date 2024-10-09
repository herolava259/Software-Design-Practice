

namespace OOPDesign.DeckOfCards;

public class Dealer
{
    private readonly Deck deck;

    public Dealer(int deckSize = 52)
    {
        deck = new Deck(deckSize);

        deck.ShuffleCards();
    }

    public void Deal(IEnumerable<Player> players, int numOfCards =13)
    {
        foreach (var player in players)
        {
            Enumerable.Range(0, numOfCards)
                      .ToList()
                      .ForEach(_ => {
                          player.AddCard(deck.GetTopCard()!);
                      });
        }
    }
}
