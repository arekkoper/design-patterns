using DesignPatterns.Application.FactoryMethod.Abstraction;
using DesignPatterns.Application.FactoryMethod.Products;

namespace DesignPatterns.Application.FactoryMethod.Creators
{
    public class ReceptionistFactory : EmployeeFactory
    {
        public override IEmployee CreateEmployee()
        {
            return new Receptionist("Gabriela", "Gabi");
        }
    }
}