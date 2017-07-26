using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Deck
    {
        List<Card> deck = new List<Card>()
            {
                new Card { Suit = "Hearts", FaceValue = "A", Value = 11 },
                new Card { Suit = "Hearts", FaceValue = "K", Value = 10 },
                new Card { Suit = "Hearts", FaceValue = "Q", Value = 10 },
                new Card { Suit = "Hearts", FaceValue = "J", Value = 10 },
                new Card { Suit = "Hearts", FaceValue = "10", Value = 10 },
                new Card { Suit = "Hearts", FaceValue = "9", Value = 9 },
                new Card { Suit = "Hearts", FaceValue = "8", Value = 8 },
                new Card { Suit = "Hearts", FaceValue = "7", Value = 7 },
                new Card { Suit = "Hearts", FaceValue = "6", Value = 6 },
                new Card { Suit = "Hearts", FaceValue = "5", Value = 5 },
                new Card { Suit = "Hearts", FaceValue = "4", Value = 4 },
                new Card { Suit = "Hearts", FaceValue = "3", Value = 3 },
                new Card { Suit = "Hearts", FaceValue = "2", Value = 2 },
                new Card { Suit = "Diamonds", FaceValue = "A", Value = 11 },
                new Card { Suit = "Diamonds", FaceValue = "K", Value = 10 },
                new Card { Suit = "Diamonds", FaceValue = "Q", Value = 10 },
                new Card { Suit = "Diamonds", FaceValue = "J", Value = 10 },
                new Card { Suit = "Diamonds", FaceValue = "10", Value = 10 },
                new Card { Suit = "Diamonds", FaceValue = "9", Value = 9 },
                new Card { Suit = "Diamonds", FaceValue = "8", Value = 8 },
                new Card { Suit = "Diamonds", FaceValue = "7", Value = 7 },
                new Card { Suit = "Diamonds", FaceValue = "6", Value = 6 },
                new Card { Suit = "Diamonds", FaceValue = "5", Value = 5 },
                new Card { Suit = "Diamonds", FaceValue = "4", Value = 4 },
                new Card { Suit = "Diamonds", FaceValue = "3", Value = 3 },
                new Card { Suit = "Diamonds", FaceValue = "2", Value = 2 },
                new Card { Suit = "Spades", FaceValue = "A", Value = 11 },
                new Card { Suit = "Spades", FaceValue = "K", Value = 10 },
                new Card { Suit = "Spades", FaceValue = "Q", Value = 10 },
                new Card { Suit = "Spades", FaceValue = "J", Value = 10 },
                new Card { Suit = "Spades", FaceValue = "10", Value = 10 },
                new Card { Suit = "Spades", FaceValue = "9", Value = 9 },
                new Card { Suit = "Spades", FaceValue = "8", Value = 8 },
                new Card { Suit = "Spades", FaceValue = "7", Value = 7 },
                new Card { Suit = "Spades", FaceValue = "6", Value = 6 },
                new Card { Suit = "Spades", FaceValue = "5", Value = 5 },
                new Card { Suit = "Spades", FaceValue = "4", Value = 4 },
                new Card { Suit = "Spades", FaceValue = "3", Value = 3 },
                new Card { Suit = "Spades", FaceValue = "2", Value = 2 },
                new Card { Suit = "Clubs", FaceValue = "A", Value = 11 },
                new Card { Suit = "Clubs", FaceValue = "K", Value = 10 },
                new Card { Suit = "Clubs", FaceValue = "Q", Value = 10 },
                new Card { Suit = "Clubs", FaceValue = "J", Value = 10 },
                new Card { Suit = "Clubs", FaceValue = "10", Value = 10 },
                new Card { Suit = "Clubs", FaceValue = "9", Value = 9 },
                new Card { Suit = "Clubs", FaceValue = "8", Value = 8 },
                new Card { Suit = "Clubs", FaceValue = "7", Value = 7 },
                new Card { Suit = "Clubs", FaceValue = "6", Value = 6 },
                new Card { Suit = "Clubs", FaceValue = "5", Value = 5 },
                new Card { Suit = "Clubs", FaceValue = "4", Value = 4 },
                new Card { Suit = "Clubs", FaceValue = "3", Value = 3 },
                new Card { Suit = "Clubs", FaceValue = "2", Value = 2 },
            };

        public void Shuffle()
        {
            Random rand = new Random();

            for (var i = 0; i < 500; i++)
            {
                var firstIndx = rand.Next(deck.Count);
                var secondIndx = rand.Next(deck.Count);

                var temp = deck[firstIndx];
                deck[firstIndx] = deck[secondIndx];
                deck[secondIndx] = temp;
            }
        }
        public Card DealCard()
        {
            Card card = deck[0];
            deck.RemoveAt(0);
            return card;
        }
    }
}
