using JobApplication.Services;
using JobDomain.Core.Interfaces.Repositories;
using JobDomain.Core.Interfaces.Services;

namespace JobApplication.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> repository;
        public ServiceBase(IRepositoryBase<T> repository)
        {
            this.repository = repository;
        }
        public async Task AddAsync(T entity)
        {
            await repository.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
           await repository.RemoveAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await repository.UpdateAsync(entity);
        }
    }
}
