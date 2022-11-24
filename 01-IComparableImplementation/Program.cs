using _01_IComparableImplementation.Entities;

namespace _01_IComparableImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 900.00));
            list.Add(new Product("Tablet", 900.00));
            list.Add(new Product("Nobreak", 900.00));

            list.Sort((p1, p2)=> p1.Name.ToUpper().CompareTo(p2.Name));   
            
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

       //static int CompareTo(Product p1,Product p2)
       // { return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); }
    }
}