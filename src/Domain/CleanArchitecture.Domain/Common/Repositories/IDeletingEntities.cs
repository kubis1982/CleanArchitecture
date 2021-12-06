namespace CleanArchitecture.Domain.Common.Repositories {
    using System.Threading;
    using System.Threading.Tasks;

    public interface IDeletingEntities<TEntity, TIdentity>
        where TEntity : class, IEntity<TIdentity>
        where TIdentity : notnull {
        Task DeleteAsync(TEntity[] entities, CancellationToken cancellationToken = default);
    }
}
