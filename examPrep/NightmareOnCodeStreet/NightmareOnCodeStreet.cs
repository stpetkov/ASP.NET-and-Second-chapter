using System;
using System.Numerics;

class NightmareOnCodeStreet

{
    static void Main()
    {
        string number =Console.ReadLine();
        int sum = 0;
        long count = 0;
        for (int i = 1; i < number.Length; i += 2)
        {
            if (i % 2 != 0 && char.IsDigit(number[i]))
            {
                count++;
                sum += number[i] - '0';
            }
            
        }
        Console.WriteLine(count + " " + sum);

    }
}

