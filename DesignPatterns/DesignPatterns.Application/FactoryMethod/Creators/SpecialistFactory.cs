
using DesignPatterns.Application.FactoryMethod.Abstraction;
using DesignPatterns.Application.FactoryMethod.Products;

namespace DesignPatterns.Application.FactoryMethod.Creators
{
    public class SpecialistFactory : EmployeeFactory
    {
        public override IEmployee CreateEmployee()
        {
            return new Specialist("Andrew", "Worholm");
        }
    }
}