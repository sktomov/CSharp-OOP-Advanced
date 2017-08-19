using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var numberOfPersons = int.Parse(Console.ReadLine());
        var sortedByName = new SortedSet<Person>();
        var sortedByAge = new HashSet<Person>(new EqualtiComparator());
        for (int i = 0; i < numberOfPersons; i++)
        {
            var personInfo = Console.ReadLine().Split(); ;
            var person = new Person(personInfo[0], int.Parse(personInfo[1]));
            sortedByName.Add(person);
            sortedByAge.Add(person);
        }

        Console.WriteLine(sortedByName.Count);
        Console.WriteLine(sortedByAge.Count);
    }


}

