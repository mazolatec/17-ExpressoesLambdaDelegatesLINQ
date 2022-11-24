using _06_Func.Entites;

namespace _07_Func
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
            // list.ForEach(p => p.Price += p.Price * 0.1);
           // List<string> result = list.Select(UperCase).ToList();
          //  Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result=list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string p in result)
            {
                Console.WriteLine(p);
            }
        }


        //static string UperCase(Product p){
        //    return p.Name.ToUpper();
        //}


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
