﻿using System;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class CustomAttribute : Attribute
{
    public CustomAttribute(string author, int revision, string description, params string[] reviewers)
    {
        this.Author = author;
        this.Description = description;
        this.Reviewers = reviewers;
        this.Revision = revision;
    }
    
    public string Author { get; private set; }
    public string Description { get; private set; }
    public string[] Reviewers { get; private set; }
    public int Revision { get; private set; }
}

