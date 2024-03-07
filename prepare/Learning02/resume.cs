using System;
{ class resume
    {
       public string _personName;


       public string List<Job> _jobs = new List<Job>();
    }


    public void DisplayJobDetails()
        {
            Console.WriteLine($"Name: {_personName}");
            Console.WriteLine("Jobs: ");


            foreach (Job Job in _jobs)
            {
                job.DisplayJobDetails();
            }
        }
    
}