using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Dealer
    {
        private List<Card> DealerHand = new List<Card>();

        public void AddACard(Card card)
        {
            DealerHand.Add(card);
        }
        public int GetValue()
        {
            int sumofCards = 0;
            foreach (Card card in DealerHand)
            {
                sumofCards += card.Value;
            }
            return sumofCards;
        }
        public void CheckForAce()
        {
            foreach (Card card in DealerHand)
            {
                if (card.FaceValue == "A")
                {
                    card.Value = 1;
                }
            }
        }
        public void PrintHand()
        {
            foreach (Card card in DealerHand)
            {
                Console.WriteLine(card.FaceValue + " of " + card.Suit);
            }
        }

        public static void DHitOrStay(Player p, Dealer d, Deck k)
        {
            Dealer.EvaluateScores(p.GetValue(), d.GetValue());
            while (d.GetValue() < 17)
            {
                d.AddACard(k.DealCard());
            }
        }

        public static void EvaluateScores(int pcardvalue, int dcardvalue)
        {
            if (pcardvalue == 21 && dcardvalue != 21)
            {
                Console.WriteLine("Player has a Blackjack!  Game over.");
            }

            if (dcardvalue == 21)
            {
                if (dcardvalue == pcardvalue)
                {
                    Console.WriteLine("Both players have 21, game is a push");
                }
                else
                {
                    Console.WriteLine("Game over, dealer has " + dcardvalue + ": Blackjack");
                }
            }
        }
    }
}
