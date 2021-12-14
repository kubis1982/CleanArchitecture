namespace CleanArchitecture.Persistance.EntityFrameworkCore {
    using CleanArchitecture.Domain.Common;
    using CleanArchitecture.Domain.Common.Repositories;
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;

    public class Repository<TEntity> : IInsertingEntity<TEntity, int>, IInsertingEntities<TEntity, int>, IUpdatingEntity<TEntity, int>, IUpdatingEntities<TEntity, int>, IDeletingEntity<TEntity, int>, IDeletingEntities<TEntity, int>, IContainingEntities, IContainingEntity<TEntity, int>, IGettingEntities<TEntity>, IGettingEntity<TEntity, int> 
        where TEntity : class, IEntity<int> {
        private readonly ApplicationDbContext applicationDbContext;

        internal Repository(ApplicationDbContext applicationDbContext) {
            this.applicationDbContext = applicationDbContext;
        }

        public async virtual Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default) {
            applicationDbContext.Add(entity);
            await SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async virtual Task<TEntity[]> InsertAsync(TEntity[] entities, CancellationToken cancellationToken = default) {
            applicationDbContext.AddRange(entities);
            await SaveChangesAsync(cancellationToken);
            return entities;
        }

        public async virtual Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default) {
            applicationDbContext.Remove(entity);
            await SaveChangesAsync(cancellationToken);
        }

        public async virtual Task DeleteAsync(TEntity[] entities, CancellationToken cancellationToken = default) {
            applicationDbContext.RemoveRange(entities);
            await SaveChangesAsync(cancellationToken);
        }

        public async virtual Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default) {
            if (applicationDbContext.Entry(entity).State == EntityState.Detached) applicationDbContext.Update(entity);
            await SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async virtual Task<TEntity[]> UpdateAsync(TEntity[] entities, CancellationToken cancellationToken = default) {
            applicationDbContext.UpdateRange(entities);
            await SaveChangesAsync(cancellationToken);
            return entities;
        }

        public virtual Task<bool> ContainsAsync(CancellationToken cancellationToken = default) {
            return applicationDbContext.Set<TEntity>().AnyAsync(cancellationToken);
        }
        public Task<bool> ContainsAsync(TEntity entity, CancellationToken cancellationToken = default) {
            return applicationDbContext.Set<TEntity>().AnyAsync(n => n.Id == entity.Id, cancellationToken);
        }

        public Task<TEntity> GeEntity(int identity, CancellationToken cancellationToken = default) {
            return applicationDbContext.Set<TEntity>().FindAsync(identity).AsTask();
        }

        public virtual Task<TEntity[]> GetEntities(CancellationToken cancellationToken = default) {
            return applicationDbContext.Set<TEntity>().ToArrayAsync();
        }

        protected virtual Task SaveChangesAsync(CancellationToken cancellationToken) {
            return applicationDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
