using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int PNumbers = 0;
            for (int i = 2; PNumbers < 1000; i++)
            {
                int Counter = 0;
                for (int j = 2; j < 1000; j++)
                {
                    if (i != j)
                    {
                        if (i % j == 0)
                        {
                            Counter = Counter + 1;
                            
                        }
                        
                    }
                }
                if (Counter == 0){Console.WriteLine(i); PNumbers++;}
                
            }
            
        }
    }
}