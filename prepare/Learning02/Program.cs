using System;

class Program
{
    static void Main(string[] args)
    {
        
    
        Job job1 = new job();

        job1._jobTitle ="Pilot";
        job1._nameOfTheCompany ="United Airlines";
        job1._startYear ="1995";
        job1._endYear ="2030";


        Job job2 = new job();

        job2._jobTitle ="CEO";
        job2._nameOfTheCompany ="American Airlines";
        job2._startYear ="1985";
        job2._endYear ="2050";


        resume myResume = new resume();
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobDetails();
        
        
    }


}