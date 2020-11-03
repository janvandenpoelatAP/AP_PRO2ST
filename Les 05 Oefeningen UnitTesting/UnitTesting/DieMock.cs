using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class DieMock : IDie
    {
        private int _result;

        public int RollIsCalledNTimes { get; set; }

        public DieMock(int result)
        {
            _result = result;
        }

        public int Roll()
        {
            RollIsCalledNTimes++;
            return _result;
        }
    }
}
