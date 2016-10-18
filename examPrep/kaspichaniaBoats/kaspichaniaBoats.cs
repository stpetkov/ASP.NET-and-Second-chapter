using System;

namespace kaspichaniaBoats
{
    class kaspichaniaBoats
    {
        static void Main()
        {
            int n = 5;//int.Parse(Console.ReadLine());
            char dot = '.';
            char star = '*';
            int boatSize = n * 2+1;
            int mid = n;
            for (int col = 0; col < boatSize-1; col++)
            {
                for (int row = 0; row < boatSize; row++)
                {
                    if (col==mid ||
                        col==0 && row==mid 
                        
                        
                        )
                    {
                        Console.Write(star);
                    }
                    else
                        
                    {
                        Console.Write(dot);
                    }                 
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
