using System;
class textToNumber
{
    static void Main()
    {
        ulong M = ulong.Parse(Console.ReadLine());
        string txt = Console.ReadLine();
        ulong result = 0;
        for (int i = 0; i < txt.Length; i++)
        {            
            if (Char.IsLower(txt[i]))
            {
                result += (ulong)(txt[i] - 'a');
            }
            if (Char.IsUpper(txt[i]))
            {
                result += (ulong)(txt[i] - 'A');
            }
            if (Char.IsNumber(txt[i]))
            {
                result *= (ulong)(txt[i] - '0');
            }
            if (txt[i].Equals('@'))
            {
                Console.WriteLine(result);
                break;
            }
            else
            {
                result %= M;
            }
        }
    }
}

