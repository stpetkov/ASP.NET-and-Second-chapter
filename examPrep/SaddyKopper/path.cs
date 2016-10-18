using System;


class path
{
    static void Main(string[] args)
    {
        int pathLong = int.Parse(Console.ReadLine()); 
        for (int i = pathLong; i >= 0; i--)
        {
            for (int j = 0; j <= pathLong; j++)
            {
                
                if (i == j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i <= pathLong; i++)
        {
            for (int j = 0; j <= pathLong; j++)
            {

                if (i == j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}
