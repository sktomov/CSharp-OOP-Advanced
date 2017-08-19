using System;
using System.Linq;
using System.Text;

public class Weapon : IWeapon
{
    private Gem[] gems;

    public Weapon(string rare, string weaponType, string name)
    {

        this.WeaponType = (WeaponType)Enum.Parse(typeof(WeaponType), weaponType);
        this.Rare = (Rare)Enum.Parse(typeof(Rare), rare);
        this.Name = name;
        this.CalculateBaseDamage();

    }


    public string Name { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public int NumberOfSockets { get; set; }
    public WeaponType WeaponType { get; set; }
    public Rare Rare { get; set; }

    public void Add(int index,Gem gem)
    {
        if (this.gems.Length >= index && index >= 0)
        {
            this.gems[index] = gem;
            for (int i = 0; i < gem.Strength; i++)
            {
                this.MinDamage += 2;
                this.MaxDamage += 3;
            }
            for (int i = 0; i < gem.Agility; i++)
            {
                this.MinDamage += 1;
                this.MaxDamage += 4;
            }
        }
    }

    public void Remove(int index)
    {
        if (this.gems.Length >= index && index >= 0)
        {
            if (this.gems[index] != null)
            {
                for (int i = 0; i < this.gems[index].Strength; i++)
                {
                    this.MinDamage -= 2;
                    this.MaxDamage -= 3;
                }
                for (int i = 0; i < this.gems[index].Agility; i++)
                {
                    this.MinDamage -= 1;
                    this.MaxDamage -= 4;
                }
                this.gems[index] = null;
            }
            
        }
    }

    private void CalculateBaseDamage()
    {
        //•	Axe(5 - 10 damage, 4 sockets)
        //•	Sword(4 - 6 damage, 3 sockets)
        //•	Knife(3 - 4 damage, 2 sockets)
        if (this.WeaponType.ToString() == "Axe")
        {
            this.MinDamage = 5;
            this.MaxDamage = 10;
            this.gems = new Gem[4];
        }
        else if (this.WeaponType.ToString() == "Sword")
        {
            this.MinDamage = 4;
            this.MaxDamage = 6;
            this.gems = new Gem[3];
        }
        else if (this.WeaponType.ToString() == "Knife")
        {
            this.MinDamage = 3;
            this.MaxDamage = 4;
            this.gems = new Gem[2];
        }

         //•	Uncommon(increases damage x2)
         //•	Rare(increases damage x3)
         //•	Epic(increases damage x5)
        if (this.Rare.ToString() == "Uncommon")
        {
            this.MinDamage *= 2;
            this.MaxDamage *= 2;
        }
        else if (this.Rare.ToString() == "Rare")
        {
            this.MinDamage *= 3;
            this.MaxDamage *= 3;
        }
        else if (this.Rare.ToString() == "Epic")
        {
            this.MinDamage *= 5;
            this.MaxDamage *= 5;
        }


    }

    public override string ToString()
    {
        //Axe of Misfortune: 5-10 Damage, +0 Strength, +0 Agility, +0 Vitality
        var strenght = 0;
        var agility = 0;
        var vitality = 0;
        foreach (var gem in this.gems.Where(g => g != null))
        {
            strenght += gem.Strength;
            agility += gem.Agility;
            vitality += gem.Vitality;
        }

        return $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, +{strenght} Strength, +{agility} Agility, +{vitality} Vitality";
    }
}

