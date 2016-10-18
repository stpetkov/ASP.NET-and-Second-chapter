using System;


    class Program
    {
        static void Main()
        {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long result=0;
        if (b == 2)
        {
            result=a % c;
        }
        if (b == 4)
        {
            result = a + c;
        }
        if (b == 8)
        {
            result = a * c;
        }
        if (result % 4 == 0)
        {
            Console.WriteLine(result/4);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(result%4);
            Console.WriteLine(result);
        }
        
    }
    }

