using System;
using System.Collections.Generic;

public class Pack
{
    private List<Card> cards;
    private Random random;

    public Pack()
    {
        cards = new List<Card>();
        random = new Random();

        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach (var suit in suits)
        {
            foreach (var number in numbers)
            {
                cards.Add(new Card(number, suit));
            }
        }
    }

    public void Shuffle()
    {
        for (int i = cards.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }

    public List<Card> DealCards(int numCards)
    {
        if (numCards > cards.Count)
        {
            throw new Exception("Not enough cards in the pack.");
        }

        var dealtCards = new List<Card>();
        for (int i = 0; i < numCards; i++)
        {
            dealtCards.Add(cards[i]);
            cards.RemoveAt(i);
        }

        return dealtCards;
    }
}
