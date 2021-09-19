using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpDesignPatterns.SOLID.OpenClosedPrinciple.Enums;

namespace CSharpDesignPatterns.SOLID.OpenClosedPrinciple.V2.Specifications
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == size;
        }
    }
}
