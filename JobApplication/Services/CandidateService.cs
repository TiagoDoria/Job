using JobDomain.Dtos.Candidate;
using JobDomain.Core.Interfaces.Repositories;
using JobDomain.Core.Interfaces.Services;
using JobDomain.Entities.Candidate;


namespace JobApplication.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            this.candidateRepository = candidateRepository;
        }

        public async Task AddAsync(CandidateDto entity)
        {
            await candidateRepository.AddAsync(entity);
        }

        public async Task<IEnumerable<CandidateDto>> GetAllAsync()
        {
            return await candidateRepository.GetAllAsync();
        }

        public async Task<CandidateDto> GetByIdAsync(int id)
        {
            return await candidateRepository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(CandidateDto entity)
        {
            await candidateRepository.RemoveAsync(entity);
        }

        public async Task UpdateAsync(CandidateDto entity)
        {
            await candidateRepository.UpdateAsync(entity);
        }
    }
}
