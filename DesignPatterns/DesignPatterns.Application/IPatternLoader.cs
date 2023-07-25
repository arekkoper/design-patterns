using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Application
{
    public interface IPatternLoader
    {
        List<IPattern> GetPatterns();
        void Load();
    }
}
