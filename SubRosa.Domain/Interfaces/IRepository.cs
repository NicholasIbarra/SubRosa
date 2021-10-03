using Microsoft.EntityFrameworkCore;
using SubRosa.Domain.Entities;
using System.Collections;
using System.Threading.Tasks;

namespace SubRosa.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Entities { get; }
        DbContext DbContext { get; }

        Task<IList> GetAllAsync();
        T Find(params object[] keyValues);
        Task FindAsync(params object[] keyValues);
        Task InsertAsync(T entity, bool saveChanges = true);
        Task InsertRangeAsync(IEnumerable entities, bool saveChanges = true);
        Task DeleteAsync(int id, bool saveChanges = true);
        Task DeleteAsync(T entity, bool saveChanges = true);
        Task DeleteRangeAsync(IEnumerable entities, bool saveChanges = true);
    }
}
