
using DesignPatterns.Application.FactoryMethod.Abstraction;
using DesignPatterns.Application.FactoryMethod.Products;

namespace DesignPatterns.Application.FactoryMethod.Factories
{
    public class SecurityFactory : EmployeeFactory
    {
        public override IEmployee Create()
        {
            return new Security(GenerateName(), GenerateSurname());
        }
    }
}