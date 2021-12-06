namespace CleanArchitecture.Domain.Common.Repositories {
    using System.Threading;
    using System.Threading.Tasks;

    public interface IUpdatingEntity<TEntity, TIdentity>
        where TEntity : class, IEntity<TIdentity>
        where TIdentity : notnull {
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
