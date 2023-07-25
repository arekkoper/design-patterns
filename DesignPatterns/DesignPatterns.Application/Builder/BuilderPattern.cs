
using DesignPatterns.Application.Builder.PizzaExample;

namespace DesignPatterns.Application.Builder
{
    public class BuilderPattern : IPattern
    {
        private readonly Dictionary<string, IBuilder> _builders = new();

        public BuilderPattern()
        {
            _builders.Add("Pizza", new PizzaBuilder());
        }

        public IBuilder GetBuilder(string name)
        {
            return _builders[name];
        }
    }
}