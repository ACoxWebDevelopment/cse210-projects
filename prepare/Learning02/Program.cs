using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1= new Job();
        job1._company="Microsoft";
        job1._jobTitle="Assistant Head Honcho";
        job1._endYear=2060;
        job1._startYear=2030;


        Job job2= new Job();
        job2._company="Apple";
        job2._jobTitle="Head Honcho";
        job2._endYear=2061;
        job2._startYear=2060;

        Resume myResume= new Resume();
        myResume._name="Allan Cox";
        myResume.myJobs.Add(job1);
        myResume.myJobs.Add(job2);

        myResume.DisplayResume();


    }
    
}