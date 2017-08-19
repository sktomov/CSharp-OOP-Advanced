using System.Linq;

public class Smartphone : ITalkable, IBrowsable
{
    public string Call(string phone)
    {
        if (IsValidToCall(phone))
        {
            return $"Calling... {phone}";
        }
        else
        {
            return $"Invalid number!";
        }
    }

    public string Browse(string url)
    {
        if (IsValidUrl(url))
        {
            return $"Browsing: {url}!";
        }
        else
        {
            return $"Invalid URL!";
        }
    }

    private bool IsValidToCall(string phone)
    {
        if (phone.Any(n => !char.IsDigit(n)))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private bool IsValidUrl(string url)
    {
        if (url.Any(n => char.IsDigit(n)))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

