using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var inputLine = Console.ReadLine().Split();
        var people = new List<Person>();
        while (inputLine[0] != "END")
        {
            var name = inputLine[0];
            var age = int.Parse(inputLine[1]);
            var town = inputLine[2];
            people.Add(new Person(name, age, town));
            inputLine = Console.ReadLine().Split();
        }

        var index = int.Parse(Console.ReadLine()) - 1;

        //Format: {number of equal people} {number of not equal people} {total number of people}
        int equal = people.Where(p => p.CompareTo(people[index]) == 0).Count() - 1;
        if (equal == 0)
        {
            Console.WriteLine("No matches");
            return;
        }
        equal++;
        int notequal = people.Count - equal;
        Console.WriteLine($"{equal} {notequal} {people.Count}");
    }
}

