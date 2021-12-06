namespace CleanArchitecture.Persistance.MongoDb {
    using CleanArchitecture.Domain.Common;
    using CleanArchitecture.Domain.Common.Repositories;
    using MongoDB.Driver;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class Repository<TEntity> : IInsertingEntity<TEntity, int>, IInsertingEntities<TEntity, int>, IUpdatingEntity<TEntity, int>, IUpdatingEntities<TEntity, int>, IDeletingEntity<TEntity, int>, IDeletingEntities<TEntity, int>, IContainingEntities, IContainingEntity<TEntity, int>, IGettingEntities<TEntity>, IGettingEntity<TEntity, int>
        where TEntity : class, IEntity<int> {
        private readonly ApplicationDbContext applicationDbContext;

        public Repository(ApplicationDbContext applicationDbContext) {
            this.applicationDbContext = applicationDbContext;
        }

        public Task<bool> ContainsAsync(CancellationToken cancellationToken = default) {
            return applicationDbContext.DbSet<TEntity>().Find(FilterDefinition<TEntity>.Empty).AnyAsync(cancellationToken);
        }

        public Task<bool> ContainsAsync(TEntity entity, CancellationToken cancellationToken = default) {
            return applicationDbContext.DbSet<TEntity>().Find(n => n.Id == entity.Id).AnyAsync(cancellationToken);
        }

        public Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default) {
            return applicationDbContext.DbSet<TEntity>().DeleteOneAsync(n => n.Id == entity.Id, cancellationToken);
        }

        public Task DeleteAsync(TEntity[] entities, CancellationToken cancellationToken = default) {
            throw new NotImplementedException();
        }

        public Task<TEntity> GeEntity(TEntity entity, CancellationToken cancellationToken = default) {
            throw new NotImplementedException();
        }

        public async Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default) {
            await applicationDbContext.DbSet<TEntity>().InsertOneAsync(entity, null, cancellationToken);
            return entity;
        }

        public async Task<TEntity[]> InsertAsync(TEntity[] entities, CancellationToken cancellationToken = default) {
            await applicationDbContext.DbSet<TEntity>().InsertManyAsync(entities, null, cancellationToken);
            return entities;
        }

        public Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default) {
            throw new NotImplementedException();
        }

        public Task<TEntity[]> UpdateAsync(TEntity[] entities, CancellationToken cancellationToken = default) {
            throw new NotImplementedException();
        }

        public async Task<TEntity[]> GetEntities(CancellationToken cancellationToken) {
            var list = await applicationDbContext.DbSet<TEntity>().FindAsync(FilterDefinition<TEntity>.Empty);
            return list.ToList().ToArray();
        }
    }
}
