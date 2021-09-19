using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.SOLID.OpenClosedPrinciple.V2
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
