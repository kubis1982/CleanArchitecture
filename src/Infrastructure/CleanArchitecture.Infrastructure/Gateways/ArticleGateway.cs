namespace CleanArchitecture.Infrastructure.Gateways {
    using CleanArchitecture.Application.UseCases.Articles;
    using CleanArchitecture.Domain.Entities.Articles;

    class ArticleGateway : IArticleGateway {
        private readonly IArticleRepository articleRepository;

        public ArticleGateway(IArticleRepository articleRepository) {
            this.articleRepository = articleRepository;
        }
    }
}
