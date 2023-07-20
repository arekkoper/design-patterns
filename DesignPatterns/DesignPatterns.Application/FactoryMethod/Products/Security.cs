
using DesignPatterns.Application.FactoryMethod.Abstraction;

namespace DesignPatterns.Application.FactoryMethod.Products
{
    public class Security : IEmployee
    {
        public Security(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; }
        public string Surname { get; }

        public string Work()
        {
            return "I'm protecting this page!";
        }
    }
}