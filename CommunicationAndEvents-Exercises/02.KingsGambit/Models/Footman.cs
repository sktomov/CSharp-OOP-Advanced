using System;

public class Footman : Soldier
{
    public Footman(string name) : base(name)
    {
        this.Hits = 2;
    }
    public int Hits { get; private set; }

    public override void KingUnderAttack(object sender, EventArgs e)
    {
        Console.WriteLine($"Footman {this.Name} is panicking!");
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

