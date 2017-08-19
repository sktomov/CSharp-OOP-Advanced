using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary, corps)
    {
        this.Repairs = new List<IRepair>();
    }

    public IList<IRepair> Repairs { get; }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine("Repairs:");
        sb.Append(" ");
        sb.AppendLine(string.Join(Environment.NewLine + " ", this.Repairs));
        return sb.ToString().Trim();
    }
}

