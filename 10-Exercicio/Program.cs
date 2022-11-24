using _10_Exercicio.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace _10_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            List<Products> products = new List<Products>();
            using (StreamReader str = File.OpenText(path))
            {
                while (!str.EndOfStream)
                {
                    string[] dat = str.ReadLine().Split(',');
                    string name = dat[0];
                    double price = double.Parse(dat[1], CultureInfo.InvariantCulture);
                    products.Add(new Products(name, price));
                }
            }

       
            var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}