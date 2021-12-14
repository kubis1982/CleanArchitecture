namespace CleanArchitecture.Domain.Common {
    public interface IEntity<T> where T : notnull {
        T Id { get; }
    }
}