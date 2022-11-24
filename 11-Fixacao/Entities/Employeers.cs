

namespace _11_Fixacao.Entities
{
    internal class Employeers
    {public string Name { get; set; }   
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employeers(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
