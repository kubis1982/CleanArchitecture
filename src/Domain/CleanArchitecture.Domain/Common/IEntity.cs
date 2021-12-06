namespace CleanArchitecture.Domain.Common {
    public interface IEntity<T> : IAggregate where T : notnull {
        T Id { get; }
    }
}