using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRuning = true;
    private List<Weapon> weapons;

    public Engine()
    {
        this.weapons = new List<Weapon>();
    }

    public void Run()
    {
        while (this.isRuning)
        {
            var inputLine = Console.ReadLine().Split(';');
            try
            {
                switch (inputLine[0])
                {
                    case "END":
                        this.isRuning = false;
                        break;
                    case "Create":
                        var weaponInfo = inputLine[1].Split();
                        var rare = weaponInfo[0];
                        var weaponType = weaponInfo[1];
                        var weaponName = inputLine[2];
                        var weapon = new Weapon(rare, weaponType, weaponName);
                        this.weapons.Add(weapon);
                        break;
                    case "Add":
                        var name = inputLine[1];
                        if (this.weapons.Any(w => w.Name == name))
                        {
                            var weaponToAddGem = this.weapons.FirstOrDefault(w => w.Name == name);
                            var gemInfo = inputLine[3].Split();
                            weaponToAddGem.Add(int.Parse(inputLine[2]), new Gem(gemInfo[1], gemInfo[0]));

                        }
                        break;
                    case "Remove":
                        var nameToRemove = inputLine[1];
                        if (this.weapons.Any(w => w.Name == nameToRemove))
                        {
                            var weaponToRemoveGem = this.weapons.FirstOrDefault(w => w.Name == nameToRemove);

                            var index = int.Parse(inputLine[2]);
                            weaponToRemoveGem.Remove(index);
                        }
                        break;
                    case "Print":
                        var nameToPrint = inputLine[1];
                        if (this.weapons.Any(w => w.Name == nameToPrint))
                        {
                            var weapontToPrint = this.weapons.FirstOrDefault(w => w.Name == nameToPrint);
                            Console.WriteLine(weapontToPrint);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                
            }
            
        }
    }
}

