public class Threeuple<T1, T2, T3>
{
    private T1 _firstItem;
    private T2 _secondItem;
    private T3 _thirdItem;

    public Threeuple(T1 firstItem, T2 secondItem, T3 thirdItem)
    {
        this.FirstItem = firstItem;
        this.SecondItem = secondItem;
        this.ThirdtItem = thirdItem;
    }

    public T1 FirstItem
    {
        get => this._firstItem;
        set { this._firstItem = value; }
    }

    public T2 SecondItem
    {
        get => this._secondItem;
        set { this._secondItem = value; }
    }

    public T3 ThirdtItem
    {
        get => this._thirdItem;
        set { this._thirdItem = value; }
    }

    public override string ToString()
    {
        return $"{this.FirstItem} -> {this.SecondItem} -> {this.ThirdtItem}";
    }
}

