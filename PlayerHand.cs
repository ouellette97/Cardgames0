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
        public int HandSize 
        { 
            get 
            { 
                return cards.Count; 
            } 
        }
    }
}
