using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Tour Leader";
        job1._company = "Europe Experience";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Cook";
        job2._company = "Cigierre";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Guidara Michele";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}