using System;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay weekDay;
    private string notes;

    public WeeklyEntry(string weekDay, string notes)
    {
        Enum.TryParse(weekDay, out this.weekDay);
        this.Notes = notes;  
    }

    public WeekDay WeekDay
    {
        get => this.weekDay;
        private set => this.weekDay = value;
    }

    public string Notes
    {
        get => this.notes;
        private set => this.notes = value;
    }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if(ReferenceEquals(null, other)) return 1;
        var weekComparison = weekDay.CompareTo(other.WeekDay);
        if (weekComparison != 0)
        {
            return weekComparison;
        }
        return string.Compare(this.Notes, other.Notes, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }
}

