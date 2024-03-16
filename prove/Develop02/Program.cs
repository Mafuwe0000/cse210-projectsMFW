using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        
    Console.WriteLine("Welcome to the Journal Program");
    string filepath = "journal.txt";
    
    Journal myJournal = new Journal(filepath);
      while (true)
      {
        var random = new Random();
        var list = new List<string> {"What was your favorite part of the day?", "List three goals that you successfuly attained today", "What did you learnt today?", "What happened today", "What was the most interesting thing You Saw or Heard Today?", "What are you grateful for today?", "How can you describe your day?","What about write something for your posterity?"};
        int index = random.Next(list.Count);

        Console.WriteLine(list[index]);
    
      
        Console.WriteLine("\n 1. Write: \n 2.Load \n 3.Save \n 4. Quit ");
        Console.WriteLine("Please select one of the following choices:");
        string menuSelection = Console.ReadLine();
        if (menuSelection =="1")
        {
            Console.WriteLine(" Feel free to write what made your day today:");
            string answer = Console.ReadLine();
            myJournal.AddEntry(answer) ;
        }
        else if (menuSelection =="2")
        {
            Console.WriteLine("What file do you want to be loaded?");
            string loadingAnswer = Console.ReadLine();
            myJournal.LoadingFromAFile(loadingAnswer);
        }  
        else if (menuSelection =="3")
        {
            Console.WriteLine("What do you want to be saved?");
            string savedAnswers = Console.ReadLine();
            myJournal.SavedToAFile(savedAnswers);
        }  
        else if (menuSelection =="4")
        {
            Console.WriteLine("Exiting from my journal App");
            return;
        }
        else
        {
            Console.WriteLine("Please make a different choice");
        }
      }  
    }   
    }