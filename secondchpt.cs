using System;
class secondchpt
{
    static void Main(string[] args)
    {
        bool isMale = true;
        char hexChar = (char)0x48;
        string hello = "Hello";
        string world = "World";
        object hw = hello + " " + world;
        Console.WriteLine(hw);
        string more = hw.ToString();
        Console.WriteLine(more);
        string quotedS = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotedS);
        string unQuotedS = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(unQuotedS);

        char copyrightSymbol = (char)0xA9;
        int columnNumber = 10;
        int rowNumber = 3;
        int character = 1;
        for (int i = 0; i < rowNumber; i++)
        {
            Console.Write(new string(' ', columnNumber - i - 1));
            Console.Write(new string(copyrightSymbol, i * 2 + 1));
            character += 2;
            Console.WriteLine();
        }
        string firstName;
        string lastName;
        int age;
        char gender;
        long ID;
        int firstN = 5;
        int secondN = 10;
        Console.WriteLine(firstN+" - "+secondN);
        int temp = firstN;
        firstN = secondN;
        secondN = temp;
        Console.WriteLine(firstN + " - " + secondN);
    }
}

