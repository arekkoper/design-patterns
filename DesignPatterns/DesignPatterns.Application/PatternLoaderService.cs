
using System.Reflection;

namespace DesignPatterns.Application
{
    public class PatternLoaderService : IPatternLoader
    {
        private readonly List<IPattern> _patterns = new List<IPattern>();

        public List<IPattern> GetPatterns()
        {
            return _patterns;
        }

        public void Load()
        {
            var interfaceType = typeof(IPattern);
            var patternTypes = Assembly.GetAssembly(interfaceType)!
                .GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && interfaceType.IsAssignableFrom(t));

            foreach (var patternType in patternTypes)
            {
                IPattern patternInstance = (IPattern)Activator.CreateInstance(patternType)!;
                _patterns.Add(patternInstance);
            }
        }
    }
}