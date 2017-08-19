using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Stack<T> : IEnumerable<T>
{
    private List<T> _stackList;

    public Stack()
    {
        this._stackList = new List<T>();
    }

    public void Push(params T[] elements)
    {
        this._stackList.InsertRange(0,elements.Reverse());
    }

    public void Pop()
    {
        if (this._stackList.Count > 0)
        {
            this._stackList.RemoveAt(0);
        }
        else
        {
            Console.WriteLine("No elements");
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this._stackList.Count; i++)
        {
            yield return this._stackList[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

