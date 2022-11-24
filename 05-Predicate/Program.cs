using _05_Predicate.Entites;

namespace _05_Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));
           // list.RemoveAll(p => p.Price == 80.90);
            list.RemoveAll(TestaProduct);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static bool TestaProduct(Product p)
        {
            return p.Price <= 100.0;
        }
    }
}