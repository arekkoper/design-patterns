namespace DesignPatterns.Application.FactoryMethod.Abstraction
{
    public abstract class EmployeeFactory
    {
        public abstract IEmployee CreateEmployee();

        public string GoToWork()
        {
            var employee = CreateEmployee();

            return employee.Work();
        }
    }
}