
using DesignPatterns.Application.AbstractFactory.Abstraction;
using DesignPatterns.Application.AbstractFactory.Factories;

namespace DesignPatterns.Application.AbstractFactory
{
    public class AbstractFactoryPattern : IPattern
    {
        private readonly Dictionary<string, ClothesFactory> _factories = new();

        public AbstractFactoryPattern()
        {
            _factories.Add("CasualClothesFactory", new CasualClothesFactory());
            _factories.Add("ElegantClothesFactory", new ElegantClothesFactory());
        }

        public ClothesFactory GetClothesFactory(string factory)
        {
            return _factories[factory];
        }
    }
}