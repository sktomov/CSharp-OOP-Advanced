using System;

public abstract class Soldier
{
    protected Soldier(string name)
    {
        this.Name = name;
    }
    
    public int Hits { get; private set; }
    public string Name { get; private set; }

    public abstract void KingUnderAttack(object sender, EventArgs e);

    public abstract bool CanTakeHits();
}

