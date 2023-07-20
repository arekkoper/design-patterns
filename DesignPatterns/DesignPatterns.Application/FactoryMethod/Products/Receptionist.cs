using DesignPatterns.Application.FactoryMethod.Abstraction;

namespace DesignPatterns.Application.FactoryMethod.Products
{
    public class Receptionist : IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Receptionist(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Work()
        {
            return "I'm working in reception";
        }
    }
}