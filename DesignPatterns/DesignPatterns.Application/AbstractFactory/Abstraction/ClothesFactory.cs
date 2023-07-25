namespace DesignPatterns.Application.AbstractFactory.Abstraction
{
    public abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrousers();
    }
}