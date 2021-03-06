using CompanyManager.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManager.Models.Interface
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
    }
}
