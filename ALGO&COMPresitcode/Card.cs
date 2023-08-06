using System;

public class Card
{
    public int Number { get; set; }
    public string Suit { get; set; }

    public Card(int number, string suit)
    {
        Number = number;
        Suit = suit;
    }

    public override string ToString()
    {
        return $"{Number} {Suit}";
    }
}
