using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext applicationDBContext;
        public GenericRepository(ApplicationDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }
        public async Task<T> AddSync(T entity)
        {
           await applicationDBContext.AddAsync(entity);
           await applicationDBContext.SaveChangesAsync();
           return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var enity = await applicationDBContext.Set<T>().FindAsync(id);
            if (enity != null)
            {
                applicationDBContext.Set<T>().Remove(enity);
            }

            await applicationDBContext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var enity = await GetAsync(id);
            return enity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await applicationDBContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await applicationDBContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            applicationDBContext.Update(entity);
            await applicationDBContext.SaveChangesAsync();
        }
    }
}
