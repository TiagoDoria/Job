using JobDomain.Dtos.Candidate;
using JobDomain.Core.Interfaces.Repositories;
using JobDomain.Entities.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobInfrastructure.Data.Repositories
{
    public class CandidateRepository : RepositoryBase<CandidateDto>, ICandidateRepository
    {
        private readonly SqlContext sqlContext;

        public CandidateRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
