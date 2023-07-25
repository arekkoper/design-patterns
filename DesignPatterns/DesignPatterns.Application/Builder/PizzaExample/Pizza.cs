namespace DesignPatterns.Application.Builder.PizzaExample
{
    public class Pizza
    {
        public string Name { get; set; } = default!;
        public string Size { get; set; } = default!;
        public List<string> Toppings { get; set; } = new List<string>();
        public bool HasCheese { get; set; }
    }
}