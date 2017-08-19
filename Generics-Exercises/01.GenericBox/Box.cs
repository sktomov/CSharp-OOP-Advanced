using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

public class Box<T>
    where T:IComparable
{
    private T element;
    private List<string> data;

    public Box()
    {
        this.data = new List<string>();
    }
   

    public void Add(string element)
    {
        this.data.Add(element);
    }

    public void Remove(int index)
    {
        this.data.RemoveAt(index);
    }

    public string Contains(string pattern)
    {
        bool result = this.data.Contains(pattern);
        return result.ToString();
    }
    public void Swap(int firstIndex, int lastIndex)
    {
        string tmp = this.data[firstIndex];
        this.data[firstIndex] = this.data[lastIndex];
        this.data[lastIndex] = tmp;
    }

    public string Max()
    {
        return this.data.Max();
    }
    public string Min()
    {
        return this.data.Min();
    }
    public int Greater(T pattern)
    {
        int counter = 0;
        foreach (var element in data)
        {
            if (element.CompareTo(pattern) > 0)
            {
                counter++;
            }
        }
        return counter;
    }

    public void Sort()
    {
        var temp = data.OrderBy(x => x).ToList();
        data = temp;
    }
    public void Print()
    {
        data.ForEach(x => Console.WriteLine(string.Join(Environment.NewLine, x)));
    }
    public override string ToString()
    {
        return $"{this.element.GetType().FullName}: {this.element}";
    }
}

