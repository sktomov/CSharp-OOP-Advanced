using System;
using System.Collections.Generic;
using System.Linq;

[Custom("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
public class StartUp
{
    public static void Main()
    {
        //var engine = new Engine();
        //engine.Run();

        var cmds = new List<string>();
        var input = Console.ReadLine();
        while (input != "END")
        {
            cmds.Add(input);
            input = Console.ReadLine();
        }
        var attributes = (CustomAttribute)typeof(StartUp).GetCustomAttributes(false).First();
        foreach (var cmd in cmds)
        {
            if (cmd == "Author")
            {
                Console.WriteLine($"Author: {attributes.Author}");
            }
            else if (cmd == "Revision")
            {
                Console.WriteLine($"Revision: {attributes.Revision}");
            }
            else if (cmd == "Description")
            {
                Console.WriteLine($"Class description: {attributes.Description}");
            }
            else if (cmd == "Reviewers")
            {
                Console.WriteLine($"Reviewers: {string.Join(", ", attributes.Reviewers)}");
            }
        }
    }

}


