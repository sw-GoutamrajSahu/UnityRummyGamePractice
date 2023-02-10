using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script.Cards
{
    [System.Serializable]
    public enum CardType
    {
        None = 0,
        Clubs,
        Spades,
        Diamonds,
        Hearts
    }
    public enum CardValue
    {
        None = 0,
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

    [System.Serializable]
    public class CardData
    {
        public CardType ThisCardType;
        public CardValue ThisCardValue;
        public CardData(int Type, int Value)
        {
            ThisCardType = (CardType)Type;
            ThisCardValue = (CardValue)Value;
        }
    }
}
