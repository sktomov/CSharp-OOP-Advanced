using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class StartUp
{
    
 
    public static void Main()
    {
        
        
        var firstPlayer = Console.ReadLine().Trim();
        var secondPlayer = Console.ReadLine().Trim();
        var firstPlayerCards = new HashSet<Card>();
        var secondPlayerCards = new HashSet<Card>();

        AddingCardsPlayerOne(firstPlayerCards);
        AddingCardsPlayerTwo(secondPlayerCards, firstPlayerCards);

        var firstplayerMaxCard = firstPlayerCards.OrderByDescending(c => c.Power()).First();
        var secondplayerMaxCard = secondPlayerCards.OrderByDescending(c => c.Power()).First();
        if (firstplayerMaxCard.Power() >= secondplayerMaxCard.Power())
        {
            Console.WriteLine($"{firstPlayer} wins with {firstplayerMaxCard}.");
        }
        else
        {
            Console.WriteLine($"{secondPlayer} wins with {secondplayerMaxCard}.");
        }


    }

    private static void AddingCardsPlayerOne(HashSet<Card> playerCards)
    {
        while (playerCards.Count < 5)
        {
            var inputLine = Console.ReadLine().Split(new [] { " of " }, StringSplitOptions.RemoveEmptyEntries);
            var rank = inputLine[0];
            var suit = inputLine[1];

            if (CheckForValidCards(rank, suit))
            {
                var card = new Card(rank, suit);
                if (playerCards.
                    Any(c => c.ToString() == $"{rank} of {suit}"))
                {
                    Console.WriteLine("Card is not in the deck.");
                }
                else
                {
                    playerCards.Add(card);
                }
            }
            else
            {
                Console.WriteLine("No such card exists.");
            }
        }
    }
    private static void AddingCardsPlayerTwo(HashSet<Card> playerCards, HashSet<Card> playerTwoCards)
    {
        while (playerCards.Count < 5)
        {
            var inputLine = Console.ReadLine().Split(new[] { " of " }, StringSplitOptions.RemoveEmptyEntries);
            var rank = inputLine[0];
            var suit = inputLine[1];

            if (CheckForValidCards(rank, suit))
            {
                var card = new Card(rank, suit);
                if (playerCards.
                    Any(c => c.ToString() == $"{rank} of {suit}") || playerTwoCards.
                        Any(c => c.ToString() == $"{rank} of {suit}"))

                {
                    Console.WriteLine("Card is not in the deck.");
                }
                else
                {
                    playerCards.Add(card);
                }
            }
            else
            {
                Console.WriteLine("No such card exists.");
            }
        }
    }

    private static bool CheckForValidCards(string rank, string suit)
    {
        var ranks = new List<string>(Enum.GetNames(typeof(Rank)));
        var suits = new List<string>(Enum.GetNames(typeof(Suit)));

        if (ranks.Contains(rank) && suits.Contains(suit))
        {
            return true;
        }
        return false;
    }
}

