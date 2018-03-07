using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRASDemo
{
    public class FactorialUtil
    {
        public long Factorial(long x)
        {
            if (x < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (x > 1)
            {
                return x * Factorial(x - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
