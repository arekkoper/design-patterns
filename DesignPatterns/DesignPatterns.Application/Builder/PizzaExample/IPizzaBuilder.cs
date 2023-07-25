using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Application.Builder.PizzaExample
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder SetName(string name);
        IPizzaBuilder SetSize(string size);
        IPizzaBuilder AddCheese();
        IPizzaBuilder AddTopping(string topping);
        Pizza Build();
    }
}
