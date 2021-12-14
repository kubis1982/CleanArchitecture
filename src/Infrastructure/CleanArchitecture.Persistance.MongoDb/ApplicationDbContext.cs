namespace CleanArchitecture.Persistance.MongoDb {
    using CleanArchitecture.Domain.Entities;
    using MongoDB.Bson.Serialization;
    using MongoDB.Bson.Serialization.IdGenerators;
    using MongoDB.Driver;

    public class ApplicationDbContext {
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase mongoDatabase;

        public ApplicationDbContext(string connectionString) {
            mongoClient = new MongoClient(connectionString);
            mongoDatabase = mongoClient.GetDatabase("CleanArchitectureDb");

            Configure();
        }

        public IMongoCollection<T> DbSet<T>() {
            return mongoDatabase.GetCollection<T>(typeof(T).Name);
        }

        private void Configure() {
            BsonClassMap.RegisterClassMap<Article>(cm => {
                cm.MapIdMember(x => x.Id).SetIdGenerator(ObjectIdGenerator.Instance);
            });
        }
    }
}
