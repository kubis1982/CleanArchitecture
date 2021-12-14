namespace CleanArchitecture.Domain.Common.Repositories {
    using System.Threading;
    using System.Threading.Tasks;

    public interface IGettingEntity<TEntity, TIdentity> 
        where TEntity : class, IEntity<TIdentity>
        where TIdentity : notnull {
        Task<TEntity> GeEntity(TIdentity identity, CancellationToken cancellationToken = default);
    }
}
