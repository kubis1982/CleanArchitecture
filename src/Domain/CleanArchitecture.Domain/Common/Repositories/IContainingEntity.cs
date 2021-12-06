namespace CleanArchitecture.Domain.Common.Repositories {
    using System.Threading;
    using System.Threading.Tasks;

    public interface IContainingEntity<TEntity, TIdentity>
        where TEntity : class, IEntity<TIdentity>
        where TIdentity : notnull {
        Task<bool> ContainsAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
