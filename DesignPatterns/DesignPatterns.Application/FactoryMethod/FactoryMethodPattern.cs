using DesignPatterns.Application.FactoryMethod.Abstraction;
using DesignPatterns.Application.FactoryMethod.Factories;

namespace DesignPatterns.Application.FactoryMethod
{
    public class FactoryMethodPattern : IPattern
    {
        private readonly Dictionary<string, EmployeeFactory> _factories = new();

        public FactoryMethodPattern()
        {
            _factories.Add("receptionist", new ReceptionistFactory());
            _factories.Add("specialist", new SpecialistFactory());
            _factories.Add("security", new SecurityFactory());
        }

        public EmployeeFactory GetEmployeeFactory(string product)
        {
            return _factories[product];
        }

        


    }
}