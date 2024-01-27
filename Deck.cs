using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        private List<Card> cards;
        public List<Card> dealt;
        
        public Deck() 
        {
            cards = new List<Card>();
            dealt = new List<Card>();

            for (Suit S = Suit.Club; S <= Suit.Diamond; S++)
            {
                for (FaceValue F = FaceValue.Ace; F <= FaceValue.King; F++)
                {
                    cards.Add(new Card(F, S));
                }
            }

           // cards.Select(x => (x, ))
        }

        public Card Draw() 
        {
            if (cards.Count == 0)
            {
                Console.WriteLine("The deck is empty.");
                return null;
            }
            Card DrawnCard = cards[0];
            dealt.Add(DrawnCard);
            cards.RemoveAt(0);
            return DrawnCard;
        }

        public List<Card> DealPlayers(int Handsize)
        {
            List<Card> hand = new List<Card>();

            for(int i = 0; i < Handsize; i++)
            {
                Card dealtCard = Draw();
                if (dealtCard != null)
                {
                    hand.Add(dealtCard);
                }
                else 
                { 
                    return hand;
                }
             }
            return hand;
        }

        public void Shuffle()
        {
            Random rand = new Random();
            int n = cards.Count;

            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        //public void addDeck()
        //{
        //    Deck deck2 = new Deck();
        //    cards.AddRange(deck2);
        //}
        public void ResetandShuffle()
        {
            cards.Clear();
            Deck deck = new Deck();
            Shuffle();
        }
        public int RemCards()
        {
            return cards.Count;
        }
    }
}
