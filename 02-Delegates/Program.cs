using _03_Delegates.Services;

namespace _03_Delegates
{
    internal class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            double result=op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}