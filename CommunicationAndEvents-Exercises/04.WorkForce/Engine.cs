using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private List<Employee> employees;
    private List<Job> jobs;
    private  bool isWorking = true;

    public Engine()
    {
        this.employees = new List<Employee>();
        this.jobs = new List<Job>();
    }

    public void Run()
    {
        while (isWorking)
        {
            var inputLine = Console.ReadLine().Split();
            switch (inputLine[0])
            {
                case "End":
                    this.isWorking = false;
                    break;
                case "StandartEmployee":
                    Employee stdEmployee = new StandartEmployee(inputLine[1]);
                    employees.Add(stdEmployee);
                    break;
                case "Status":
                    foreach (var job in jobs)
                    {
                        Console.WriteLine(job);
                    }
                    break;
                case "Pass":
                    foreach (var job in jobs)
                    {
                        job.Update();
                    }
                    break;
                case "PartTimeEmployee":
                    Employee partEmployee = new PartTimeEmployee(inputLine[1]);
                    employees.Add(partEmployee);
                    break;
                case "Job":
                    string jobName = inputLine[1];
                    int workingHoursRequired = int.Parse(inputLine[2]);
                    Employee employee = employees.FirstOrDefault(e => e.Name == inputLine[3]);
                    Job jobToAdd = new Job(jobName, workingHoursRequired, employee);
                    jobs.Add(jobToAdd);
                    break;
            }
            CleanJobs(this.jobs);
        }
    }

    private void CleanJobs(List<Job> jobs)
    {
        if (jobs.Any(j => j.HoursOfWorkRequired <= 0))
        {
            List<Job> jobsToRemove = jobs.Where(j => j.HoursOfWorkRequired <= 0).ToList();
            foreach (var jobToRemove in jobsToRemove)
            {
                Console.WriteLine($"Job {jobToRemove.Name} done!");
                jobs.Remove(jobToRemove);
            }
        }
    }   
}

