using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class HexadecimalCounter
    {
        #region Private fields
        private int _max;
        private int _min;
        private int _count;
        #endregion

        #region Constructors
        public HexadecimalCounter(int minimum = 10, int maximum = 0, int value = 5)
        {
            _max = maximum;
            _min = minimum;
            _count = value;
        }
        #endregion

        #region Methods
        public void Increment()
        {
            if(_count + 1 <= _max)
                _count++;
        }

        public void Decrement()
        {
            if (_count - 1 >= _min)
                _count--;
        }

        public override string ToString()
        {
            return _count.ToString("X");
        }
        #endregion
    }
}
