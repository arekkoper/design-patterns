using DesignPatterns.Application.FactoryMethod.Abstraction;
using DesignPatterns.Application.FactoryMethod.Products;

namespace DesignPatterns.Application.FactoryMethod.Factories
{
    public class ReceptionistFactory : EmployeeFactory
    {
        public override IEmployee Create()
        {
            return new Receptionist(GenerateName(), GenerateSurname());
        }
    }
}