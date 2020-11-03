using System;

namespace VoorbeeldDebugging3
{
    class Program
    {
        static int Main()
        {
            int a, b, c;
            a = 1;
            b = 2;
            c = 0;
            for (int i = 0; i < 10; i++)
            {
                a++;
                b *= 2;
                c = a + b;
            }
            return 0;
        }
    }
}
