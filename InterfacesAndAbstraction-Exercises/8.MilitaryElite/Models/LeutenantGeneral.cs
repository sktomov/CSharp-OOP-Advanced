using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, double salary) : 
        base(id, firstName, lastName, salary)
    {
        this.Privates = new List<ISoldier>();
    }

    public IList<ISoldier> Privates { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Privates:");
        sb.Append(" ");
        sb.AppendLine(string.Join(Environment.NewLine + " ",this.Privates));
        return sb.ToString().Trim();
    }
}

