using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var lights = Console.ReadLine().Split();
        var trafficLights = new List<TrafficLight>();
        foreach (var light in lights)
        {
            trafficLights.Add(new TrafficLight(light));
        }
        int numberOfCycles = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCycles; i++)
        {
            trafficLights.ForEach(l => l.ChangeLight());
            Console.WriteLine(string.Join(" ", trafficLights));
        }
    }
}

