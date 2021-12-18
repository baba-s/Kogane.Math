using System;

namespace Kogane
{
    public static class KoganeMath
    {
        public static double RoundByMultiple( double value, double unit )
        {
            return Math.Round( value / unit ) * unit;
        }
    }
}