using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Blackjackhand : PlayerHand
    {
        public Blackjackhand() : base() { }

        public int HandTotal()
        {
            int Total = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                switch (cards[i].faceValue)
                {
                    case FaceValue.Ace: 
                        { 
                            Total += 1;
                            break;
                        }
                    case FaceValue.Two: Total += 2; break;
                    case FaceValue.Three: Total += 3; break;
                    case FaceValue.Four: Total += 4; break;
                    case FaceValue.Five: Total += 5; break;
                    case FaceValue.Six: Total += 6; break;
                    case FaceValue.Seven: Total += 7; break;
                    case FaceValue.Eight: Total += 8; break;
                    case FaceValue.Nine: Total += 9; break;
                    case FaceValue.Ten:
                    case FaceValue.Jack:
                    case FaceValue.Queen:
                    case FaceValue.King: Total += 10; break;
                    default: break;
                }
            }
            return Total;
        }
    }
}
