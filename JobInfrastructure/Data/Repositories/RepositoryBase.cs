using JobDomain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace JobInfrastructure.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class 
    {
        private readonly SqlContext sqlContext;
        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public async Task AddAsync(T entity)
        {
            try
            {
                await sqlContext.AddAsync(entity);
                await sqlContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await sqlContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await sqlContext.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            try
            {
                sqlContext.Set<T>().Remove(entity);
                await sqlContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                sqlContext.Entry(entity).State = EntityState.Modified;
                await sqlContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
