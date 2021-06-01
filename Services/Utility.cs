using System;

namespace Services
{
    public class Utility : IUtility
    {
        public int GetGCD(int a, int b)
        {
            if (b == 0) return a;
            else if (a < b) return GetGCD(a, b % a);
            else return GetGCD(b, a % b);
        }
    }
}
