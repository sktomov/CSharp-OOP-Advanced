using System;

public class King
{
    public King(string name)
    {
        this.Name = name;
    }

    public string Name { get; private set; }

    public event EventHandler UnderAttack;

    public void Attack()
    {
        Console.WriteLine($"King {this.Name} is under attack!");
        if (UnderAttack != null)
        {
            UnderAttack(this, new EventArgs());
        }
    }
}

