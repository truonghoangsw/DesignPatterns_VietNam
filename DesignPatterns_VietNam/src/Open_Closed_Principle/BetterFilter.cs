using System.Collections.Generic;

namespace Open_Closed_Principle
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
                if(spec.IsSatisfied(i))
                    yield return i;
        }
    }
}