using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Player
    {

        private List<Card> PlayerHand = new List<Card>();
        public void AddACard(Card card)
        {
            PlayerHand.Add(card);
        }

        public int GetValue()
        {
            int sumofCards = 0;
            foreach (Card card in PlayerHand)
            {
                sumofCards += card.Value;
            }
            return sumofCards;
        }
        public void CheckForAce()
        {
            foreach (Card card in PlayerHand)
            {
                if (card.FaceValue == "A")
                {
                    card.Value = 1;
                }
            }
        }
        public void PrintHand()
        {
            foreach (Card card in PlayerHand)
            {
                Console.WriteLine(card.FaceValue + " of " + card.Suit);
            }
        }
        public static void PHitOrStay(Player p, Dealer d, Deck k)
        {
            if (p.GetValue() < 21 && d.GetValue() != 21)
            {
                Console.Write("\nHit or Stay? ");
                string phitorStay = "";
                phitorStay = (Console.ReadLine());

                if (phitorStay.Equals("Stay", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("\nPlayer stays, the game has ended.");
                    Console.WriteLine("\nPlayer's hand was: " + p.GetValue());
                    Dealer.DHitOrStay(p, d, k);
                    Console.WriteLine("Dealer's hand was: " + d.GetValue());
                    if (d.GetValue() > 21)
                    {
                        Console.WriteLine("Dealer Busts...\nPlayer Wins");
                    }
                    else if (p.GetValue() > d.GetValue())
                    {
                        Console.WriteLine("Player Wins");
                    }
                    else if (p.GetValue() < d.GetValue())
                    {
                        Console.WriteLine("Dealer Wins");
                    }
                    else
                    {
                        Console.WriteLine("The game is a push");
                    }
                }

                else if (phitorStay.Equals("Hit", StringComparison.CurrentCultureIgnoreCase))
                {
                    p.AddACard(k.DealCard());
                    p.CheckForAce();
                    Console.WriteLine("\nPlayer hit, the hand is now: " + p.GetValue());
                    p.PrintHand();
                    //Console.WriteLine("\nThe card total is now: " + p.GetValue());

                    if (p.GetValue() < 21)
                    {
                        Player.PHitOrStay(p, d, k);
                        {
                            Dealer.EvaluateScores(p.GetValue(), d.GetValue());
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlayer Busted!!!");
                    }
                }
            }
        }
    }
}
