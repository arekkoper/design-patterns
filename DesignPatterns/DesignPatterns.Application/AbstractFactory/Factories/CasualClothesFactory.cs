
using DesignPatterns.Application.AbstractFactory.Abstraction;
using DesignPatterns.Application.AbstractFactory.Entites;

namespace DesignPatterns.Application.AbstractFactory.Factories
{
    public class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}