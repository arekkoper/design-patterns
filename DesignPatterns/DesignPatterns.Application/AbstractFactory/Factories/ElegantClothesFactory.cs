using DesignPatterns.Application.AbstractFactory.Abstraction;
using DesignPatterns.Application.AbstractFactory.Entites;

namespace DesignPatterns.Application.AbstractFactory.Factories
{
    public class ElegantClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new DressShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new SuitTrousers();
        }
    }
}