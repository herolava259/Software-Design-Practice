

namespace OOPDesign.DeckOfCards;

public static class CardComparator
{
    public static bool Before(this Card card, Card otherCard)
    {
        if ((int)card.Suit < (int)otherCard.Suit)
            return true;

        if((int)card.Suit == (int)otherCard.Suit)
        {
            if((int)card.Rank < (int)otherCard.Rank)
                return true;
        }

        return false;
    }
}


public class CardComparer : IComparer<Card>
{
    public int Compare(Card? x, Card? y)
    {
        if (x is null && y is null)
            return 0;

        else if (x is null)
            return -1;
        else if (y is null)
            return 1;

        if ((int)x.Rank == (int)y.Rank && (int)x.Suit == (int)y.Suit)
            return 0;
        else if (x < y)
            return -1;
        else
            return 1;
    }
}
