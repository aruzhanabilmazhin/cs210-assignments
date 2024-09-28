using System;

public class Entry
{
    
    private string _prompt;
    private string _response;
    private string _date;

    
    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    
    public string FormatForSave()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    
    public static Entry FromFormattedString(string formatted)
    {
        var parts = formatted.Split('|');
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }
}
