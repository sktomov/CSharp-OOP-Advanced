using System;
using System.Linq;
using System.Reflection;

public class Program
{
    static void Main()
    {
        var typeOfHarvest = typeof(HarvestingFields);
        var fields = typeOfHarvest.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        var inputLine = Console.ReadLine();

        while (inputLine != "HARVEST")
        {
            switch (inputLine)
            {
                case "all":
                    PrintAll(fields);
                    break;
                case "private":
                    PrintPrivates(fields);
                    break;
                case "protected":
                    PrintProtected(fields);
                    break;
                case "public":
                    PrintPublic(fields);
                    break;
            }

            inputLine = Console.ReadLine();
        }

    }

    private static void PrintAll(FieldInfo[] fields)
    {
        foreach (var fieldInfo in fields)
        {
            var fieldType = fieldInfo.Attributes.ToString().ToLower();
            if (fieldType == "family")
            {
                fieldType = "protected";
            }
            Console.WriteLine($"{fieldType} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
        }
    }
    private static void PrintPrivates(FieldInfo[] fields)
    {
        foreach (var fieldInfo in fields.Where(f => f.IsPrivate))
        {
            var fieldType = fieldInfo.Attributes.ToString().ToLower();
            Console.WriteLine($"{fieldType} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
        }
    }
    private static void PrintProtected(FieldInfo[] fields)
    {
        foreach (var fieldInfo in fields.Where(f => f.IsFamily))
        {
            var fieldType = fieldInfo.Attributes.ToString().ToLower();
            Console.WriteLine($"protected {fieldInfo.FieldType.Name} {fieldInfo.Name}");
        }
    }
    private static void PrintPublic(FieldInfo[] fields)
    {
        foreach (var fieldInfo in fields.Where(f => f.IsPublic))
        {
            var fieldType = fieldInfo.Attributes.ToString().ToLower();
            Console.WriteLine($"{fieldType} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
        }
    }
}

