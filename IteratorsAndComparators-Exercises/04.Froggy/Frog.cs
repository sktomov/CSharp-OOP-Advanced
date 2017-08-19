using System;
using System.Collections;
using System.Collections.Generic;
public class Frog<T> :IEnumerable<T>
{
    private List<T> stones;

    public Frog(params T[] stones)
    {
        this.stones = new List<T>(stones);
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.stones.Count; i += 2)
        {
            yield return this.stones[i];
        }
        var backPoint = this.stones.Count - 1;

        if (this.stones.Count % 2 != 0)
        {
            backPoint = this.stones.Count - 2;
        }
        for (int i = backPoint; i > 0; i -= 2)
        {
            yield return this.stones[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

