namespace CleanArchitecture.Domain.Common.Repositories {
    using System.Threading;
    using System.Threading.Tasks;

    public interface IContainingEntities {
        Task<bool> ContainsAsync(CancellationToken cancellationToken = default);
    }
}
