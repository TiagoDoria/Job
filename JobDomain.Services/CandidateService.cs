using JobDomain.Core.Interfaces.Repositories;
using JobDomain.Core.Interfaces.Services;
using JobDomain.Entities.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDomain.Services
{
    public class CandidateService : ServiceBase<Candidate>, ICandidateService
    {
        private readonly ICandidateRepository candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository) : base(candidateRepository)
        {
            this.candidateRepository = candidateRepository;
        }
    }
}
