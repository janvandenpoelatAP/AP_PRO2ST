using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class Die : IDie
    {
        private static readonly Random random = new Random();

        public int Roll()
        {
            return random.Next(5) + 1;
        }
    }
}
