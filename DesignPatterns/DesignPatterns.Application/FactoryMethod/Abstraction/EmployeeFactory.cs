namespace DesignPatterns.Application.FactoryMethod.Abstraction
{
    public abstract class EmployeeFactory
    {
        public abstract IEmployee Create();

        public string GenerateName()
        {
            var names = new List<string>(){
                "Emma",
                "Liam",
                "Olivia",
                "Noah",
                "Ava",
                "Oliver",
                "Isabella",
                "Sophia",
                "Elijah",
                "Charlotte"
            };

            return names[GetRandomIndex(names.Count)];
        }

        public string GenerateSurname()
        {
            var surnames = new List<string>(){
                "Smith",
                "Johnson",
                "Brown",
                "Williams",
                "Jones",
                "Miller",
                "Davis",
                "Garcia",
                "Wilson",
                "Martinez"
            };

            return surnames[GetRandomIndex(surnames.Count)];
        }

        private int GetRandomIndex(int max)
        {
            var random = new Random();
            return random.Next(0, max);
        }
    }
}