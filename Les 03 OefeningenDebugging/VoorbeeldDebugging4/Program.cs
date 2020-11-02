using System;

namespace VoorbeeldDebugging4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 1;
            b = 2;
            for (int i = 0; i < 10; i++)
            {
                a = a + b;
            }
        }
    }
}
