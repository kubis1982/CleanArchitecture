namespace CleanArchitecture.Domain.Common.Repositories {
    using System.Threading;
    using System.Threading.Tasks;

    public interface IInsertingEntities<TEntity, TIdentity> 
        where TEntity : class, IEntity<TIdentity>
        where TIdentity : notnull {
        Task<TEntity[]> InsertAsync(TEntity[] entities, CancellationToken cancellationToken = default);
    }
}
