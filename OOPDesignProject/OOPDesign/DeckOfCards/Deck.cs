

namespace OOPDesign.DeckOfCards;

public class Deck
{
    public List<Card> DeckOfCards { get; private init; }
    public Deck(int numOfCards = 52)
    {
        var deckOfCards = new List<Card>(); 
        for (int i = 0; i < numOfCards; i++) {

            deckOfCards.Add(CardFactory.CreateCard(i));
        }

        DeckOfCards = deckOfCards;
    }

    public void ShuffleCards()
    {
        (DeckOfCards).Shuffle();
    }

    public void SortCards()
    {

        DeckOfCards.Sort(new CardComparer());
    }

    public void AddCard(Card card)
    {
        this.DeckOfCards.Add(card);
    }

    public void ShowDeck()
    {
        this.DeckOfCards.ForEach(c =>
        {
            Console.WriteLine($"{c.Suit.ToString()}  {c.Rank.ToString()}");
        });
    }

    public Card? GetTopCard()
    {
        if (DeckOfCards.Count == 0)
            return default;
        Card c = DeckOfCards[0];

        DeckOfCards.RemoveAt(0);

        return c;
    }
}
