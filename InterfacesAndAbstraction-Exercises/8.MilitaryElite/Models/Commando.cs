using System;
using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary, corps)
    {
        this.Missions = new List<IMission>();
    }

    public IList<IMission> Missions { get; private set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine("Missions:");
        sb.Append(" ");
        sb.AppendLine(string.Join(Environment.NewLine + " ", this.Missions));
        return sb.ToString().Trim();
    }
}

