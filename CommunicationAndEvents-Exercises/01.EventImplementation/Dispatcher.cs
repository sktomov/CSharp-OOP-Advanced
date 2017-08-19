using System;

public delegate void  NameChangeEventHandler(object sender, NameChangeEventArgs e);
public class Dispatcher
{

    private string name;

    public string Name
    {
        get => this.name;
        set
        {
            this.name = value;
            OnNameChange(new NameChangeEventArgs(value));
        }
    }

    public event NameChangeEventHandler NameChange;

    private void OnNameChange(NameChangeEventArgs e)
    {
        if (NameChange != null)
        {
            NameChange(this, e);
        }
    }

    
}

