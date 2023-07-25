namespace DesignPatterns.Application.Builder.PizzaExample
{
    public class PizzaBuilder : IPizzaBuilder, IBuilder
    {
        private readonly Pizza _pizza;

        public PizzaBuilder()
        {
            _pizza = new Pizza();
        }

        public IPizzaBuilder SetName(string name)
        {
            _pizza.Name = name;
            return this;
        }

        public IPizzaBuilder AddCheese()
        {
            _pizza.HasCheese = true;
            return this;

        }

        public IPizzaBuilder AddTopping(string topping)
        {
            _pizza.Toppings.Add(topping);
            return this;

        }

        public IPizzaBuilder SetSize(string size)
        {
            _pizza.Size = size;
            return this;
        }

        public Pizza Build()
        {
            return _pizza;
        }


    }
}