using _11_Fixacao.Entities;
using System.Globalization;


namespace _11_Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employeers> list = new List<Employeers>();
            using (StreamReader str = File.OpenText(path))
            {
                while (!str.EndOfStream)
                {
                    string[] dat = str.ReadLine().Split(',');
                    string name = dat[0];
                    string email= dat[1];
                    double salary = double.Parse(dat[2], CultureInfo.InvariantCulture);
                    list.Add(new Employeers(name, email,salary));
                }
            }
            var emails = list.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);

            var sum = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

            Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
    }
