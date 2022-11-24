
using System.Collections;
using System.Linq;

namespace _08_Linq_Introducao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            
            Console.Write("Vc gostaraia de multiplicar impar(I) ou par(P) ");
            char ch=char.Parse(Console.ReadLine().ToUpper().Trim());
            // ChangeOddValues(numbers, ch);
            // Print(numbers);
            if (ch == 'P')
            {
                // var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10
                IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
                foreach (int x in result)
                {
                    Console.Write(x+" ");

                }
                //Console.WriteLine("Multiplicando Numeros Pares: "+ result);
            }
            else
            {
                var result = numbers.Where(x => x % 2 != 0).Select(x => x * 10);
                foreach (int x in result)
                {
                    Console.Write(x + " ");
                }
            }
          
           
            Console.ReadKey();
        }

        public static void ChangeOddValues(int[] numbers ,char ch)
        {
            if (ch == 'P')
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    // if (numbers[i] % 2 != 0) ver se é impar
                    if (numbers[i] % 2 == 0)
                    {
                        numbers[i] = +numbers[i] * 10;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    // if (numbers[i] % 2 != 0) ver se é impar
                    if (numbers[i] % 2 != 0)
                    {
                        numbers[i] = +numbers[i] * 10;
                    }
                }
            }
           
        }
        public static void Print(int[] n) 
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }
        }
    }
}