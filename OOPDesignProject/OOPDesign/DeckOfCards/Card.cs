
using static OOPDesign.DeckOfCards.DeckOfCardEnum;

namespace OOPDesign.DeckOfCards;

public class Card
{
    public ESuit Suit { get; private init; }

    public ERank Rank { get; private init; }

    public Card(ESuit suit, ERank rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public static bool operator <(Card card1, Card card2) => card1.Before(card2);

    public static bool operator >(Card card1, Card card2) => card2.Before(card1);

}
