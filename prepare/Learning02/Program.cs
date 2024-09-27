using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job employer1 = new Job();
        employer1._company="GE";
        employer1._jobTitle="BMET 1";
        employer1._startYear=1994;
        employer1._endYear=2012;
        
        Job employer2= new Job();
        employer2._company="Aramark";
        employer2._jobTitle="BMET 3";
        employer2._startYear=2012;
        employer2._endYear=2019;
        //employer1.Display();
        Resume myResume= new Resume();
        myResume._name="Allan Cox";
        myResume._jobs.Add(employer1);
        myResume._jobs.Add(employer2);
        myResume.Display();
        
    }
}