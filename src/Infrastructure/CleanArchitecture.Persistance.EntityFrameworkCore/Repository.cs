namespace CleanArchitecture.Persistance.EntityFrameworkCore {
    using CleanArchitecture.Domain.Common;
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

        public async Task Insert(T entity, CancellationToken cancellationToken = default) {
            applicationDbContext.Add(entity);
            await applicationDbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Insert(T[] entities, CancellationToken cancellationToken = default) {
            applicationDbContext.AddRange(entities);
            await applicationDbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(T entity, CancellationToken cancellationToken = default) {
            applicationDbContext.Remove(entity);
            await applicationDbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(T[] entities, CancellationToken cancellationToken = default) {
            applicationDbContext.RemoveRange(entities);
            await applicationDbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Update(T entity, CancellationToken cancellationToken = default) {
            applicationDbContext.Update(entity);
            await applicationDbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Update(T[] entities, CancellationToken cancellationToken = default) {
            applicationDbContext.UpdateRange(entities);
            await applicationDbContext.SaveChangesAsync(cancellationToken);
        }

        public Task<T> Get(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) {
            return Task.FromResult(applicationDbContext.Set<T>().Where(predicate).SingleOrDefault());
        }

        public Task<IEnumerable<T>> GetArray(CancellationToken cancellationToken = default) {
            return Task.FromResult(applicationDbContext.Set<T>().ToList().AsEnumerable());
        }

        public Task<IEnumerable<T>> GetArray(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) {
            return Task.FromResult(applicationDbContext.Set<T>().Where(predicate).ToList().AsEnumerable());
        }

        public Task<bool> Any(CancellationToken cancellationToken = default) {
            return Task.FromResult(applicationDbContext.Set<T>().Any());
        }

        public Task<bool> Any(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) {
            return Task.FromResult(applicationDbContext.Set<T>().Any(predicate));
        }
    }
}
