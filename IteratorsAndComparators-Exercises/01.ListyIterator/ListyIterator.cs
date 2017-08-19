using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> _data;
    private int index;

    public ListyIterator(params T[] income)
    {
        this._data = new List<T>();
        this._data.AddRange(income);
        this.index = 0;
    }

    public bool Move()
    {
        if (this._data.Count > this.index + 1)
        {
            this.index++;
            return true;
        }
        else
        {
            return false;
        } 
    }

    public bool HasNext()
    {
        if (this._data.Count > this.index + 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Print()
    {
        if (this._data.Count == 0)
        {
            Console.WriteLine("Invalid Operation!");
        }
        else
        {
            Console.WriteLine(this._data[index]);
        }
    }

    public void PrintAll()
    {
        Console.WriteLine(string.Join(" ", this._data));
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this._data.Count; i++)
        {
            yield return this._data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

