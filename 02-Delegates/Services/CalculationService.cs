

using System.Reflection.Metadata.Ecma335;

namespace _03_Delegates.Services
{
    static class CalculationService
    {
        public static double Max(double x, double y)
        {
             return (x > y) ? x : y;
            //if (x > y)
            //{
            //    return x;
            //}
            //else return y;

          
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        //Ou quadrad
        public static double Square(double x)
        {
            return x * x;
        }
    }
}
