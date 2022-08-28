using JobDomain.Core.Interfaces.Repositories;
using JobDomain.Entities.Candidate;
using JobDomain.Entities.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobInfrastructure.Data.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        private readonly SqlContext sqlContext;

        public CompanyRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
