
using DesignPatterns.Application.FactoryMethod.Abstraction;
using DesignPatterns.Application.FactoryMethod.Creators;
using DesignPatterns.Application.FactoryMethod.Products;

namespace DesignPatterns.Application.FactoryMethod
{
    public class FactoryMethodPattern : IPattern
    {
        private readonly Dictionary<string, EmployeeFactory> _factories = new();

        public FactoryMethodPattern()
        {
            _factories.Add("receptionist", new ReceptionistFactory());
            _factories.Add("specialist", new SpecialistFactory());
        }

        public EmployeeFactory GetEmployeeFactory(string product)
        {
            return _factories[product];
        }

        


    }
}