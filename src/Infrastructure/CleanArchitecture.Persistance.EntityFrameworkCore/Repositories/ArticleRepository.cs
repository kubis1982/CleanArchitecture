namespace CleanArchitecture.Persistance.EntityFrameworkCore.Repositories {
    using CleanArchitecture.Domain.Entities;
    using CleanArchitecture.Domain.Repositories;

    public class ArticleRepository : Repository<Article>, IArticleRepository {
        public ArticleRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) {
        }
    }
}
