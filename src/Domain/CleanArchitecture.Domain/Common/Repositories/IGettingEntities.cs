namespace CleanArchitecture.Domain.Common.Repositories {
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IGettingEntities<TEntity> where TEntity : class, IAggregate {
        Task<TEntity[]> GetEntities(CancellationToken cancellationToken = default);
    }
}
