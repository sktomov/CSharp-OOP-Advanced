using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var inputLine = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
        var army = new List<ISoldier>();
        while (inputLine[0] != "End")
        {
            try
            {
                switch (inputLine[0])
                {
                    case "Private":
                        PrintPrivate(inputLine.Skip(1).ToArray(), army);
                        break;
                    case "LeutenantGeneral":
                        PrintLeutenantGeneral(inputLine.Skip(1).ToArray(), army);
                        break;
                    case "Commando":
                        string corp = inputLine[5];
                        if (corp != "Airforces" && corp != "Marines")
                        {
                            break;
                        }
                        PrintCommando(inputLine.Skip(1).ToArray(), army);
                        break;
                    case "Engineer":
                        string corp2 = inputLine[5];
                        if (corp2 != "Airforces" && corp2 != "Marines")
                        {
                            break;
                        }
                        PringEngineer(inputLine.Skip(1).ToArray(), army);
                        break;
                    case "Spy":
                        PrintSpy(inputLine.Skip(1).ToArray(), army);
                        break;
                    default:
                        break;
                }
                
            }
            catch (Exception e)
            {

            }
            inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var soldier in army)
        {
            Console.WriteLine(soldier);
        }
    }

    private static void PrintSpy(string[] args, List<ISoldier> army)
    {
        string id = args[0];
        string firstName = args[1];
        string lastName = args[2];
        int codeNumber = int.Parse(args[3]);
        var spy = new Spy(id, firstName, lastName, codeNumber);
        army.Add(spy);
    }

    private static void PringEngineer(string[] args, List<ISoldier> army)
    {
        string id = args[0];
        string firstName = args[1];
        string lastName = args[2];
        double salary = double.Parse(args[3]);
        string corp = args[4];
        if (corp == "Airforces" || corp == "Marines")
        {
            var engineer = new Engineer(id, firstName, lastName, salary, corp);

            if (args.Length > 5)
            {
                args = args.Skip(5).ToArray();
                for (int i = 0; i < args.Length; i++)
                {
                    var partName = args[i];
                    i++;
                    var workingHours = int.Parse(args[i]);
                    var repair = new Repair(partName, workingHours);
                    engineer.Repairs.Add(repair);

                }
            }
            army.Add(engineer);
        }
    }

    private static void PrintCommando(string[] args, List<ISoldier> army)
    {
        string id =args[0];
        string firstName = args[1];
        string lastName = args[2];
        double salary = double.Parse(args[3]);
        string corp = args[4];

        var commando = new Commando(id, firstName, lastName, salary, corp);


        args = args.Skip(5).ToArray();
        for (int i = 0; i < args.Length - 1; i += 2)
        {
            if (args[i + 1] != "inProgress" && args[i + 1] != "Finished")
            {
                continue;
            }
            var mission = new Mission(args[i], args[i + 1]);
            commando.Missions.Add(mission);
        }

        army.Add(commando);
    }

    private static void PrintLeutenantGeneral(string[] args, List<ISoldier> army)
    {
        string id = args[0];
        string firstName = args[1];
        string lastName = args[2];
        double salary = double.Parse(args[3]);

        var general = new LeutenantGeneral(id, firstName, lastName, salary);

        args = args.Skip(3).ToArray();

        for (int i = 0; i < args.Length; i++)
        {
            var soldier = army.FirstOrDefault(s => s.Id == args[i]);
            if (soldier != null)
            {
                general.Privates.Add(soldier);
            }
        }
        army.Add(general);
    }

    private static void PrintPrivate(string[] args, List<ISoldier> army)
    {
        string id = args[0];
        string firstName = args[1];
        string lastName = args[2];
        double salary = double.Parse(args[3]);
        var privateSoldier = new Private(id, firstName, lastName, salary);
        army.Add(privateSoldier);

    }
}

