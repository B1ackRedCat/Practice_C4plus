using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Counter
    {
        private readonly int _maximum;
        private readonly int _minimum;

        public int Value { private set; get; }

        public Counter(int maximum, int minimum, int counter)
        {
            _maximum = maximum;
            _minimum = minimum;
            counter = Math.Min(_maximum, counter);
            counter = Math.Max(_minimum, counter);
            this.Value = counter;
        }

        private Counter() 
        {
            _maximum = 10;
            _minimum = 0;
            this.Value = 5;
        }

        public void Increase()
        {
            var value = this.Value + 1;
            if (value > _maximum || value < _minimum)
                return;
            this.Value++;
        }

        public void Decrease()
        {
            var value = this.Value - 1;
            if (value > _maximum || value < _minimum)
                return;
            this.Value--;
        }
    }
}
