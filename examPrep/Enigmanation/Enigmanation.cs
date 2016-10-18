using System;


    class Enigmanation
    {
        static void Main()
        {
        string expression= Console.ReadLine();
        char remind = '%';
        char plus = '+';
        char minus = '-';
        char multy = '*';
        char equal = '=';
        double result = 0;
        double resultForNow = 0;
        
            for(int i = 1; i < expression.Length-4; i+=4)
        {
            if (expression[i] == remind)
            {
                result = (expression[i-1]-'0') % (expression[i+1]-'0');
                if (expression[i] == remind)
                {
                    result %= (expression[i + 3] - '0');
                }
                if (expression[i+2] == plus)
                {
                    result += (expression[i + 3] - '0');
                }
                if (expression[i+2] == minus)
                {
                    result -= (expression[i + 3] - '0');
                }
                if (expression[i+2] == multy)
                {
                    result *= (expression[i + 3] - '0');
                }
                if (expression[i + 4] == plus)
                {
                    resultForNow += result;
                }
                if (expression[i + 4] == remind)
                {
                    resultForNow %= result;
                }
                if (expression[i + 4] == minus)
                {
                    resultForNow -= result;
                }
                if (expression[i + 4] == multy)
                {
                    resultForNow *= result;
                }



            }
            if (expression[i] == plus)
            {
                result = (expression[i-1] - '0') + (expression[i + 1] - '0');
                if (expression[i] == remind)
                {
                    result %= (expression[i + 3] - '0');

                }
                if (expression[i + 2] == plus)
                {
                    result += (expression[i + 3] - '0');
                }
                if (expression[i + 2] == minus)
                {
                    result -= (expression[i + 3] - '0');
                }
                if (expression[i + 2] == multy)
                {
                    result *= (expression[i + 3] - '0');
                }
                
                
            }
            if (expression[i] == minus)
            {
                result = (expression[i - 1] - '0') - (expression[i + 1] - '0');
                if (expression[i] == remind)
                {
                    result %= (expression[i + 3] - '0');

                }
                if (expression[i + 2] == plus)
                {
                    result += (expression[i + 3] - '0');
                }
                if (expression[i + 2] == minus)
                {
                    result -= (expression[i + 3] - '0');
                }
                if (expression[i + 2] == multy)
                {
                    result *= (expression[i + 3] - '0');
                }
                
                
            }
            if (expression[i] == multy)
            {
                result = (expression[i - 1] - '0') * (expression[i + 1] - '0');
                if (expression[i] == remind)
                {
                    result %= (expression[i + 3] - '0');

                }
                if (expression[i + 2] == plus)
                {
                    result += (expression[i + 3] - '0');
                }
                if (expression[i + 2] == minus)
                {
                    result -= (expression[i + 3] - '0');
                }
                if (expression[i + 2] == multy)
                {
                    result *= (expression[i + 3] - '0');
                }
            }            
            if (expression[i] == equal)
            {
                result += resultForNow;
                Console.WriteLine(result);                
            }
            resultForNow += result;
            result = 0;
            Console.WriteLine(result);
            Console.WriteLine(resultForNow);
        }
        
        }

    }

