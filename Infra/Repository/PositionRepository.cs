using CompanyManager.Infra.Context;
using CompanyManager.Models;
using CompanyManager.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManager.Infra.Repository
{
    public class PositionRepository : GenericRepository<Position>, IPositionRepository
    {
        public PositionRepository(CompanyContext companyContext): base(companyContext)
        {

        }
    }
}
