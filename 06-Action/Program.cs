
using _06_Action.Entites;
namespace _06_Action
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
           // Action<Product> act = UpdateProduct_10; 
            list.ForEach(p =>p.Price += p.Price *0.1);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //static void UpdateProduct_10(Product p)
        //{
        //    p.Price += p.Price * 0.10;   
        //}
        //static void UpdateProduct_20(Product p)
        //{
        //    p.Price += p.Price * 0.20;
        //}
    }
}