public class Job
{
    //Job <nameOfJob> <hoursOfWorkRequired> <employeeName>”

    public Job(string name, int hoursOfWorkRequired, Employee employee)
    {
        this.Name = name;
        this.HoursOfWorkRequired = hoursOfWorkRequired;
        this.Employee = employee;
    }

    public string Name { get; set; }
    public int HoursOfWorkRequired { get; set; }
    public Employee Employee { get; set; }

    public void Update()
    {
        this.HoursOfWorkRequired -= this.Employee.WorkHoursPerWeek;
    }

    public override string ToString()
    {
        return $"Job: {this.Name} Hours Remaining: {this.HoursOfWorkRequired}";
    }
}

