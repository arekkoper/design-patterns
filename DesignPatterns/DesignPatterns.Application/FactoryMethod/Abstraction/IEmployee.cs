using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Application.FactoryMethod.Abstraction
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Work();
    }
}
