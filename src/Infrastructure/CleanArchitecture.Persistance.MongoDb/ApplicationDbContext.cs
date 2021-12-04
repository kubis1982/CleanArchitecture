namespace CleanArchitecture.Persistance.MongoDb {
    using MongoDB.Driver;

    public class ApplicationDbContext {
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase mongoDatabase;

        public ApplicationDbContext(string connectionString) {
            mongoClient = new MongoClient(connectionString);
            mongoDatabase = mongoClient.GetDatabase("CleanArchitectureDb");
        }

        public IMongoCollection<T> DbSet<T>() {
            return mongoDatabase.GetCollection<T>(typeof(T).Name);
        }
    }
}
