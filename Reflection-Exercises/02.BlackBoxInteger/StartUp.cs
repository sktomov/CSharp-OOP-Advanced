using System;
using System.Linq;
using System.Reflection;

public class StartUp
{
    public static void Main()
    {
        var blackBox = typeof(BlackBoxInt);
        var instanceOfBlackBox = Activator.CreateInstance(blackBox, true);

        var inputLine = Console.ReadLine().Split('_');
        while (inputLine[0] != "END")
        {
            var methodName = inputLine[0];
            var methodValue = int.Parse(inputLine[1]);

            blackBox.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                .Invoke(instanceOfBlackBox, new object[] {methodValue});
           var result = blackBox.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).First().GetValue(instanceOfBlackBox);
            Console.WriteLine(result.ToString());

            inputLine = Console.ReadLine().Split('_');
        }
    }
}

