namespace CleanArchitecture.Domain.Repositories {
    using CleanArchitecture.Domain.Common.Repositories;
    using CleanArchitecture.Domain.Entities;

    public interface IArticleRepository : IInsertingEntity<Article, int>, IUpdatingEntity<Article, int>, IDeletingEntity<Article, int>, IGettingEntity<Article, int> {
    }
}
