using System;
using System.IO;
using System.Runtime.CompilerServices;

public class Engine
{
    
    private CommandInpreter inpreter;
    public Engine()
    {
        this.inpreter = new CommandInpreter();   
    }
 

    public void Run(int numberOfLines)
    {
        while (numberOfLines > 0)
        {
            //Create, Add, Release, HasEmptyRooms, Print
            
            var commands = Console.ReadLine().Split();
            try
            {
                switch (commands[0])
                {
                    case "Create":
                        if (commands[1] == "Pet")
                        {
                            inpreter.CreatePet(commands[2], int.Parse(commands[3]), commands[4]);
                        }
                        else if (commands[1] == "Clinic")
                        {
                            inpreter.CreateClinic(commands[2], int.Parse(commands[3]));
                        }
                        break;
                    case "Add":
                        Console.WriteLine(inpreter.AddPetToClinic(commands[1], commands[2]));
                        break;
                    case "Release":
                        Console.WriteLine(inpreter.ReleaseClinic(commands[1]));
                        break;
                    case "Print":
                        if (commands.Length == 3)
                        {
                            inpreter.PrintRoomOfClinic(commands[1], int.Parse(commands[2]));
                        }
                        else if (commands.Length == 2)
                        {
                            inpreter.PrintClinic(commands[1]);
                        }
                        break;
                    case "HasEmptyRooms":
                        Console.WriteLine(inpreter.EmptyRooms(commands[1]));
                        break;
                    default:
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            numberOfLines--;
        }
    }
}

