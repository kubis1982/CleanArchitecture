namespace CleanArchitecture.Presentation.Console
{
    using CleanArchitecture.Domain.Common;
    using CleanArchitecture.Domain.Entities;
    using CleanArchitecture.Domain.ValueObjects;
    using CleanArchitecture.Persistance.EntityFrameworkCore.Repositories;
    using CleanArchitecture.Persistance.EntityFrameworkCore.SqlServer;
    using CleanArchitecture.Persistance.MongoDb;
    using MongoDB.Bson.Serialization;
    using MongoDB.Bson.Serialization.IdGenerators;
    using MongoDB.Driver;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Article article = new Article(new ArticleCode("Kod1"), "SDFSDF", new UnitName("szt."));

            //ArticleUnit articleUnit1 = new ArticleUnit(new UnitName("kg"));
            //ArticleUnit articleUnit2 = new ArticleUnit(new UnitName("m2"));

            //article.AddUnit(articleUnit1);
            //article.AddUnit(articleUnit2);

            //var dbContext = new ApplicationDbContextFactory().CreateDbContext(null);

            //ArticleRepository articleRepository = new ArticleRepository(dbContext);

            ////await articleRepository.InsertAsync(article);

            //Article article = await articleRepository.GeEntity(1);


            //ArticleUnit articleUnit1 = new ArticleUnit(new UnitName("kg11"));
            //ArticleUnit articleUnit2 = new ArticleUnit(new UnitName("m212"));

            //article.AddUnit(articleUnit1);
            //article.AddUnit(articleUnit2);

            //await articleRepository.UpdateAsync(article);
        }
    }
}
