using System;

public class Program
{
    static void Main()
    {

        var firstLine = Console.ReadLine().Split();
        var tuple = new Threeuple<string, string, string>(firstLine[0] + " " + firstLine[1], firstLine[2], firstLine[3]);
        var secondLine = Console.ReadLine().Split();
        bool isDrunk = false;
        if (secondLine[2] == "drunk")
        {
            isDrunk = true;
        }
        var tuple2 = new Threeuple<string, int, bool>(secondLine[0], int.Parse(secondLine[1]), isDrunk);
        var thirdLine = Console.ReadLine().Split();
        var tuple3 = new Threeuple<string,double, string>(thirdLine[0], Double.Parse(thirdLine[1]), thirdLine[2]);
        Console.WriteLine(tuple);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);

    }
}

