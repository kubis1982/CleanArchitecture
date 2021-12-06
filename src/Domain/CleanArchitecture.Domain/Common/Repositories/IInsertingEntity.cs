namespace CleanArchitecture.Domain.Common.Repositories {
    using System.Threading;
    using System.Threading.Tasks;

    public interface IInsertingEntity<TEntity, TIdentity>
        where TEntity : class, IEntity<TIdentity>
        where TIdentity : notnull {
        Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
