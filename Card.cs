using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum Suit
    {
        Club,
        Spade,
        Heart,
        Diamond
    }
    public enum FaceValue
    {
        Ace = 1, 
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Joker
    }
    internal class Card
    {
        public FaceValue faceValue { get; private set; }
        public Suit suit { get; private set; }

        public Card(FaceValue faceValue, Suit suit)
        {
            this.faceValue = faceValue;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{faceValue} of {suit}";
        }
        // string back to card (Overrides)
        // values, suits, 
    }
}
