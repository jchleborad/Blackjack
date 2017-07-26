using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BlackJack Game";
            Player player = new Player();
            Dealer dealer = new Dealer();
            Deck deck = new Deck();
            Console.WriteLine("A new deck has been opened...Let's Play BlackJack!");

            deck.Shuffle();
            Console.WriteLine("\nDeck Shuffled");

            player.AddACard(deck.DealCard());
            player.AddACard(deck.DealCard());
            Console.WriteLine("\nPlayer Hand is " + player.GetValue());
            player.PrintHand();

            var dcard2 = deck.DealCard();
            dealer.AddACard(deck.DealCard());
            dealer.AddACard(dcard2);
            Console.WriteLine("\nDealer is showing: " + dcard2.Value + "\n" + dcard2.FaceValue + " of " + dcard2.Suit + "\n");

            Dealer.EvaluateScores(player.GetValue(), dealer.GetValue());

            if (dealer.GetValue() != 21 && player.GetValue() != 21)
            {
                Player.PHitOrStay(player, dealer, deck);
                Dealer.DHitOrStay(player, dealer, deck);
            }

            Console.ReadLine();
        }
            }
}