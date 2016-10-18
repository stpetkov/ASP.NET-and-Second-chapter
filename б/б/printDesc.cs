using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime birthDate = DateTime.Parse((Console.ReadLine()));
        double myAge = ((DateTime.Now - birthDate).TotalDays) / 365.25;
        if (birthDate.Date == DateTime.Now.Date || birthDate.Date>DateTime.Now.Date)
        {
            myAge += 1;
        }
        if (myAge < 0)
        {
            myAge = 0;
        }
        Console.WriteLine(Math.Floor(myAge));
        Console.WriteLine((Math.Floor(myAge) + 10));
    }
}

