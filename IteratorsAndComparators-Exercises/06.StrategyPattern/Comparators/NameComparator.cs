
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

public class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Name.Length - y.Name.Length;
        if (result == 0)
        {
            result = (int) char.ToLower(x.Name[0]) - (int) char.ToLower(y.Name[0]);
        }
        return result;
    }
}

