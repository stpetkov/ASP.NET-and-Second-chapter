using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurvamach
{
    class subsetSums
    {
        static void Main(string[] args)
        {
            long s = long.Parse(Console.ReadLine());
            long n = long.Parse(Console.ReadLine());
            long []arr = new long[n];
            long count = 0;
            for(long i = 0; i < n; i++)
            {
                arr[i] = long.Parse(Console.ReadLine());
            }
            for (long i = 0; i < n; i++)
            {
                foreach (long item in arr)
                {
                    Console.WriteLine(arr[i] + "  " + item);
                    if (item + arr[i] == s)
                    {
                        count++;
                        if (item == arr[i])
                        {
                            count--;
                        }
                    }
                    
                }
            }
            Console.WriteLine(count);
        }
    }
}