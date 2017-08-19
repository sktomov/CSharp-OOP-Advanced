using System;

public class RoyalGuard : Soldier
{
    public RoyalGuard(string name) : base(name)
    {
        this.Hits = 3;
    }

    public int Hits { get; private set; }

    public override void KingUnderAttack(object sender, EventArgs e)
    {
        Console.WriteLine($"Royal Guard {this.Name} is defending!");
    }

    public override bool CanTakeHits()
    {
        if (this.Hits == 1)
        {
            this.Hits--;
            return false;
        }
        else
        {
            this.Hits--;
            return true;
        }
    }
}

