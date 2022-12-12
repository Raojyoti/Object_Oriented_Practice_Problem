using System;
using System.Collections.Generic;
using System.Text;

namespace Deck_Of__Cards
{
    public class DeckOfCards
    {

        public const int ncard = 52;
        public Card[] deckOfCards;
        public int currentCard;
        public Random randNum;
        public  DeckOfCards()
        {
            deckOfCards = new Card[ncard];
            int i = 0;
            for (int suit = 1; suit <= 4; suit++)
                for (int rank = 1; rank <= 13; rank++)
                    deckOfCards[i++] = new Card(suit, rank);
                     currentCard = 0;
        }

        public void Shuffle(int n)
        {
            int i, j;
            randNum = new Random();
            for (int k = 0; k < n; k++)
            {
                i = (int)(randNum.Next(ncard));
                j = (int)(randNum.Next(ncard));
                Card tmp = deckOfCards[i];
                deckOfCards[i] = deckOfCards[j];
                deckOfCards[j] = tmp;
            }

            currentCard = 0;
        }

        public Card Deal()
        {
            if (currentCard < ncard)
                return (deckOfCards[currentCard++]);
            else
                return (null);
        }
    }
    public class Card
    {
        public static string[] Rank = { "*", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        public static string[] Suit = { "*", "Clubs", "Diamonds", "Hearts", "Spades" };
        public byte cardSuit;
        public byte cardRank;
        public Card(int suit, int rank)
        {
            if (rank == 1)
                cardRank = 14;
            else
                cardRank = (byte)rank;
            cardSuit = (byte)suit;
        }

        public int Suits()
        {
            return (cardSuit);
        }

        public int Ranks()
        {
            return (cardRank);
        }

        public String toString()
        {
            return (Rank[cardRank] + Suit[cardSuit]);
        }
    }
}

