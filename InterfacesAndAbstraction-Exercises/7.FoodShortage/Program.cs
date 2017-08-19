using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = new Dictionary<string, Dictionary<string, int>>();
        int numberOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfLines; i++)
        {
            var inputLine = Console.ReadLine().Split();
            if (inputLine.Length == 4)
            {
                if (!people.ContainsKey(inputLine[0]))
                {
                    people.Add(inputLine[0], new Dictionary<string, int>());
                }
                people[inputLine[0]].Add("citizen", 0);
            }
            else if (inputLine.Length == 3)
            {
                if (!people.ContainsKey(inputLine[0]))
                {
                    people.Add(inputLine[0], new Dictionary<string, int>());
                }
                people[inputLine[0]].Add("rabel", 0);
            }
        }

        var person = Console.ReadLine().Trim();
        while (person != "End")
        {
            if (people.ContainsKey(person))
            {
                if (people[person].Keys.Any(p => p == "citizen"))
                {
                    people[person]["citizen"] += 10;
                }
                else if(people[person].Keys.Any(p => p == "rabel"))
                {
                    people[person]["rabel"] += 5;
                }
            }
            person = Console.ReadLine().Trim();
        }

        Console.WriteLine(people.Sum(p => p.Value.Sum(x => x.Value)));
    }
}

