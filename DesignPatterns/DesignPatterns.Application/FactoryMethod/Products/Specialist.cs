using DesignPatterns.Application.FactoryMethod.Abstraction;

namespace DesignPatterns.Application.FactoryMethod.Products
{
    public class Specialist : IEmployee
    {
        public Specialist(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; }
        public string Surname { get; }

        public string Work()
        {
            return "I'm working on specific problem as a specialist";
        }
    }
}