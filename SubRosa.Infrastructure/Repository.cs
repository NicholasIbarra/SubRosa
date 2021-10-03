using Microsoft.EntityFrameworkCore;
using SubRosa.Domain.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SubRosa.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbSet<T> Entities => DbContext.Set<T>();
        public DbContext DbContext { get; private set; }

        public Repository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task DeleteAsync(int id, bool saveChanges = true)
        {
            var entity = await Entities.FindAsync(id);
            await DeleteAsync(entity);

            if (saveChanges)
            {
                await DbContext.SaveChangesAsync();
            }
        }

        public Task DeleteAsync(T entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(IEnumerable entities, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task FindAsync(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<IList> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(T entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task InsertRangeAsync(IEnumerable entities, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
