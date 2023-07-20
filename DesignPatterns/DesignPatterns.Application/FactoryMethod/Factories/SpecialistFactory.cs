
using DesignPatterns.Application.FactoryMethod.Abstraction;
using DesignPatterns.Application.FactoryMethod.Products;

namespace DesignPatterns.Application.FactoryMethod.Factories
{
    public class SpecialistFactory : EmployeeFactory
    {
        public override IEmployee Create()
        {
            return new Specialist(GenerateName(), GenerateSurname());
        }
    }
}