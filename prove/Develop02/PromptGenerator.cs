using System;
using System.Collections.Generic;

public class PromptGenerator
{


    public void Display()
    {
        var random = new Random();
        var list = new List<string> {"What was your favorite part of the day?", "List three goals that you successfuly attained today", "What did you learnt today?", "What happened today", "What was the most interesting thing You Saw or Heard Today?", "What are you grateful for today?", "How can you describe your day?","What about write something for your posterity?"};
        int index = random.Next(list.Count);

        Console.WriteLine(list[index]);
    }
        
        ///https://www.tutorialspoint.com/compile_csharp_online.php
}

// CLASS STRUCTURE

/*
[ACCESS TYPE] Class [NAME]
{
    ATTRIBUTES
    CONSTRUCTORS
    METHODS
}

* Everything declared in the body of a class must be proceeded with an access type.
* No loose logic code can be in the body of the class. Must be contained inside a Method or Constructor
*/

// DECLARING CLASS OBJECT
// [CLASS TYPE] [OBJECT NAME] = NEW [CONSTRUCTOR( AAA)]