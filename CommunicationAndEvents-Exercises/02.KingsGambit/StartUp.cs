using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<Soldier> soldiers = new List<Soldier>();

        King king = new King(Console.ReadLine());

        string[] royalGuards = Console.ReadLine().Split();
        string[] footmen = Console.ReadLine().Split();

        AddingRoyals(royalGuards, king, soldiers);
        AddingFootmen(footmen, king, soldiers);

        string[] args = Console.ReadLine().Split();

        while (args[0] != "End")
        {
            switch (args[0])
            {
                case "Kill":
                    var soldierToKill = soldiers.FirstOrDefault(s => s.Name == args[1]);
                    if (!soldierToKill.CanTakeHits())
                    {
                        king.UnderAttack -= soldierToKill.KingUnderAttack;
                        soldiers.Remove(soldierToKill);
                    }
                    break;
                case "Attack":
                    king.Attack();
                    break;
            }
            args = Console.ReadLine().Split();
        }

    }

    private static void AddingFootmen(string[] footmen, King king, List<Soldier> soldiers)
    {
        foreach (var _footman in footmen)
        {
            Footman footman = new Footman(_footman);
            king.UnderAttack += footman.KingUnderAttack;
            soldiers.Add(footman);
        }
    }

    private static void AddingRoyals(string[] royalGuards, King king, List<Soldier> soldiers)
    {
        foreach (var _royalGuard in royalGuards)
        {
            RoyalGuard royalGuard = new RoyalGuard(_royalGuard);
            king.UnderAttack += royalGuard.KingUnderAttack;
            soldiers.Add(royalGuard);
        }
    }
}

