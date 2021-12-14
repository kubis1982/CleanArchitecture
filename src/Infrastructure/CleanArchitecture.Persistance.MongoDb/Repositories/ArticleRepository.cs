namespace CleanArchitecture.Persistance.MongoDb.Repositories {
    using CleanArchitecture.Domain.Entities.Articles;

    public class ArticleRepository : Repository<Article>, IArticleRepository {
        public ArticleRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) {
        }
    }
}
