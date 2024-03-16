using System;

public class Entry
{        
    
    public void Displaydate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        
                        
        Console.WriteLine($"{_date}");
        
    }
}