using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Deck_Of__Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deck = new DeckOfCards();
            deck.Shuffle(100);
            List<string>[] player = new List<string>[4];
            for (int h = 0; h < 4; h++)
            {
                player[h] = new List<string>();
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    player[j].Add(deck.Deal().toString());
                }
            }
            for (int k = 0; k < 4; k++)
            {
                List<string> sortedList = player[k].OrderBy(x => PadNumbers(x)).OrderBy(g => FaceValue(g)).ToList();
                Console.WriteLine("Player=> " + (k + 1) + ": " + string.Join("   ", sortedList));
                Console.WriteLine("\n");
            }
        }
        public static string PadNumbers(string input)
        {
            return Regex.Replace(input, "[0-9]+", match => match.Value.PadLeft(2, '0'));
        }
        public static int FaceValue(string input)
        {
            return input.Substring(0, 1) == "Ace" ? 14 : input.Substring(0, 1) == "King" ? 13 : input.Substring(0, 1) == "Queen" ? 12 : input.Substring(0, 1) == "Jack" ? 11 : 0;
        }
    }
}
