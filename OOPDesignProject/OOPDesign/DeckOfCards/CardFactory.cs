
using static OOPDesign.DeckOfCards.DeckOfCardEnum;

namespace OOPDesign.DeckOfCards;

public static class CardFactory
{
    private static Random rng = new Random();
    public static void Shuffle<T>(this IList<T> list)
    {
        
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public static Card CreateCard(int cardNum)
    {
        ESuit suit = GetSuit((cardNum / 13) + 1);
        ERank rank = GetRank((cardNum % 13) + 1);

        return new Card(suit, rank);
    }

    public static ERank GetRank(int rankNum)
    {
        if(!Enum.IsDefined(typeof(ERank), rankNum))
            return ERank.InvalidRank;

        return rankNum switch { 

            (int)ERank.Ace => ERank.Ace,
            (int)ERank.Two => ERank.Two,
            (int)ERank.Three => ERank.Three,
            (int)ERank.Four => ERank.Four,
            (int)ERank.Five => ERank.Five,
            (int)ERank.Six => ERank.Six,
            (int)ERank.Seven => ERank.Seven,
            (int)ERank.Eight => ERank.Eight,
            (int)ERank.Nine => ERank.Nine,
            (int)ERank.Jack => ERank.Jack,
            (int)ERank.Queen => ERank.Queen,
            (int)ERank.King => ERank.King,
            _ => ERank.InvalidRank
        };
    }

    public static ERank GetRank(string rankName)
    {
        if(!Enum.IsDefined(typeof(ERank), rankName))
        {
            return ERank.InvalidRank;
        }

        return Enum.Parse<ERank>(rankName);
    }

    public static ESuit GetSuit(int suitNum)
    {
        if(!Enum.IsDefined(typeof(ESuit), suitNum))
            return ESuit.InvalidSuit;

        return (ESuit)suitNum;
    }

    public static ESuit GetSuit(string suitName)
    {
        return !Array.Exists(Enum.GetNames<ESuit>(), c => c == suitName) 
                            ? ESuit.InvalidSuit 
                            : Enum.Parse<ESuit>(suitName);
    }

}
