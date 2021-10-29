using System.Collections.Generic;

namespace Zerodo.Specifications
{
    public interface IInMemoryEvaluator
    {
        IEnumerable<T> Evaluate<T>(IEnumerable<T> query, ISpecification<T> specification);
    }
}
