namespace CleanArchitecture.Persistance.EntityFrameworkCore.Repositories {
    using CleanArchitecture.Domain.Entities.Articles;

    public class ArticleRepository : Repository<Article>, IArticleRepository {
        public ArticleRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) {
        }
    }
}
