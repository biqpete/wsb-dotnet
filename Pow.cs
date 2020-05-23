using System;

namespace My.Functions
{
    public class Pow
    {
        public int Calculate(int a, int b)
        {
            if (!(a % 1 == 0 && b % 1 == 0)) throw new ArgumentOutOfRangeException("Parameters have to be integers.");

            return Convert.ToInt32(Math.Pow(a, b));
        }
    }
}
