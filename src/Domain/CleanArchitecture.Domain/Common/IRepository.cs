namespace CleanArchitecture.Domain.Common {
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRepository<T> where T : class {
        Task Insert(T entity, CancellationToken cancellationToken = default);
        Task Insert(T[] entities, CancellationToken cancellationToken = default);

        Task Delete(T entity, CancellationToken cancellationToken = default);
        Task Delete(T[] entities, CancellationToken cancellationToken = default);

        Task Update(T entity, CancellationToken cancellationToken = default);
        Task Update(T[] entities, CancellationToken cancellationToken = default); 
       
        Task<T> Get(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        Task<IEnumerable<T>> GetArray(CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetArray(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        Task<bool> Any(CancellationToken cancellationToken = default);
        Task<bool> Any(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
