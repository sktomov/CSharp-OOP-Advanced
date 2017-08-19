
using System;

public class Handler
{
    public void OnDispatcherNameChange(object sender, NameChangeEventArgs e)
    {
        Console.WriteLine($"Dispatcher's name changed to {e.Name}.");
    }
}

