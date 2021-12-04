namespace CleanArchitecture.Persistance.MongoDb {
    using CleanArchitecture.Domain.Common;
    using MongoDB.Driver;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    public class Repository<T> : IRepository<T> where T : class {
        private readonly ApplicationDbContext applicationDbContext;

        public Repository(ApplicationDbContext applicationDbContext) {
            this.applicationDbContext = applicationDbContext;
        }

        public Task<bool> Any(CancellationToken cancellationToken = default) {
            return applicationDbContext.DbSet<T>().Find(FilterDefinition<T>.Empty).AnyAsync(cancellationToken);
        }

        public Task<bool> Any(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) {
            return applicationDbContext.DbSet<T>().Find(predicate).AnyAsync(cancellationToken);
        }

        public Task Delete(T entity, CancellationToken cancellationToken = default) {
            throw new NotImplementedException();
        }

        public Task Delete(T[] entities, CancellationToken cancellationToken = default) {
            throw new NotImplementedException();
        }

        public Task<T> Get(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) {
            return applicationDbContext.DbSet<T>().Find(predicate).SingleOrDefaultAsync(cancellationToken);
        }

        public Task<IEnumerable<T>> GetArray(CancellationToken cancellationToken = default) {
            return Task.FromResult(applicationDbContext.DbSet<T>().Find(FilterDefinition<T>.Empty).ToList().AsEnumerable());
        }

        public Task<IEnumerable<T>> GetArray(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) {
            return Task.FromResult(applicationDbContext.DbSet<T>().Find(predicate).ToList().AsEnumerable());
        }

        public Task Insert(T entity, CancellationToken cancellationToken = default) {
            return applicationDbContext.DbSet<T>().InsertOneAsync(entity, null, cancellationToken);
        }

        public Task Insert(T[] entities, CancellationToken cancellationToken = default) {
            return applicationDbContext.DbSet<T>().InsertManyAsync(entities, null, cancellationToken);
        }

        public Task Update(T entity, CancellationToken cancellationToken = default) {
            throw new NotImplementedException();
        }

        public Task Update(T[] entities, CancellationToken cancellationToken = default) {
            throw new NotImplementedException();
        }
    }
}
