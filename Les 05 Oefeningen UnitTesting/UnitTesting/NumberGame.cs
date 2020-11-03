using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class NumberGame
    {
        private readonly IDie _die;

        public NumberGame(IDie die)
        {
            _die = die;
        }

        public int RateGuess(int guess)
        {
            var result = _die.Roll();

            if(result == guess)
            {
                return 2;
            }
            if(result - 1 == guess || result + 1 == guess)
            {
                return 1;
            }
            return 0;
        }
    }
}
