using System;

public class Gem : IGem
{

    public Gem(string gemType, string clarity)
    {
        this.GemType = (GemType) Enum.Parse(typeof(GemType), gemType);
        this.Clarity = (Clarity) Enum.Parse(typeof(Clarity), clarity);
        this.CalculatePower();
    }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Vitality { get; set; }
    public GemType GemType { get; set; }
    public Clarity Clarity { get; set; }

    private void CalculatePower()
    {
        //•	Ruby (+7 strength, +2 agility, +5 vitality) 
        //•	Emerald(+1strength, +4 agility, +9 vitality)
        //    •	Amethyst(+2 strength, +8 agility, +4 vitality)



        if (this.GemType.ToString() == "Ruby")
        {
            this.Strength = 7;
            this.Agility = 2;
            this.Vitality = 5;
        }
        else if (this.GemType.ToString() == "Emerald")
        {
            this.Strength = 1;
            this.Agility = 4;
            this.Vitality = 9;
        }
        else if (this.GemType.ToString() == "Amethyst")
        {
            this.Strength = 2;
            this.Agility = 8;
            this.Vitality = 4;
        }

        //•	Chipped(increases each stat by 1)
        //    •	Regular(increases each stat by 3)
        //    •	Perfect(increases each stat by 5)
        //    •	Flawless(increases each stat by 10)
        if (this.Clarity.ToString() == "Chipped")
        {
            this.Strength++;
            this.Agility++;
            this.Vitality++;
        }
        else if (this.Clarity.ToString() == "Regular")
        {
            this.Strength+=2;
            this.Agility+=2;
            this.Vitality+=2;
        }
        else if (this.Clarity.ToString() == "Perfect")
        {
            this.Strength += 5;
            this.Agility += 5;
            this.Vitality += 5; ;
        }
        else if (this.Clarity.ToString() == "Flawless")
        {
            this.Strength += 10;
            this.Agility += 10;
            this.Vitality += 10;
        }


    }
}

