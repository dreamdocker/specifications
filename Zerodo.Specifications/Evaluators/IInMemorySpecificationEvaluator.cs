using System.Collections.Generic;

namespace Zerodo.Specifications
{
    public interface IInMemorySpecificationEvaluator
    {
        IEnumerable<TResult> Evaluate<T, TResult>(IEnumerable<T> source, ISpecification<T, TResult> specification);
        IEnumerable<T> Evaluate<T>(IEnumerable<T> source, ISpecification<T> specification);
    }
}
