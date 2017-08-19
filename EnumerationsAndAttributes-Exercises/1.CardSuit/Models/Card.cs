using System;

public class Card : IComparable<Card>
{
    public Rank rank;
    public Suit suit;

    public Card(string rank, string suit)
    {
        this.rank = (Rank) Enum.Parse(typeof(Rank), rank);
        this.suit = (Suit) Enum.Parse(typeof(Suit), suit);
    }

    public int Power()
    {
        return (int) this.rank + (int) this.suit;
    }

    public int CompareTo(Card other)
    {
        return this.Power().CompareTo(other.Power());
    }

    public override string ToString()
    {
        return $"{this.rank} of {this.suit}";
    }
}

