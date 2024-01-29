using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class PlayerHand
    {
        internal List<Card> cards;

        public PlayerHand(List<Card> cards)
        {
            this.cards = cards;
        }
        public PlayerHand() 
        {
            cards = new List<Card>();
        }
        
        public void Add(Card card)
        {
            cards.Add(card);
        }
        public void Remove(Card card) 
        {
            cards.Remove(card);
        }
        public Card GetCard(int index) 
        {
            return cards[index];
        }
        
        public Card ResetHand(Card card)
        {
            while (cards.Count > 0)
            {
                this.cards.Clear();
                return card;
            }
            return card;
        }
        public int HandSize 
        { 
            get 
            { 
                return cards.Count; 
            } 
        }
    }
}
