using System;

namespace OperationsLibrary
{
    public static class Operations
    {
        public static decimal Addition(decimal x, decimal y)
        {
            return x + y;
        }

        public static decimal Subtraction(decimal x, decimal y)
        {
            return x - y;
        }

        public static decimal Multiplication(decimal x, decimal y)
        {
            return x * y;
        }

        public static decimal Division(decimal x, decimal y)
        {
            //if (y == 0)
            //{
                
            //}
            return x / y;
            
        }

        public static decimal Modulus(decimal x, decimal y)
        {
            return x % y;
        }

        public static decimal Power(decimal x, decimal y)
        {

            return (decimal)Math.Pow((double)x, (double)y);
        }
    }
}
