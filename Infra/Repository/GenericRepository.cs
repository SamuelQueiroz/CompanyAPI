using CompanyManager.Infra.Context;
using CompanyManager.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManager.Infra.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private CompanyContext _companyContext = null;

        public GenericRepository(CompanyContext companyContext)
        {
            this._companyContext = companyContext;
        }

        public async Task Add(T obj)
        {
            await _companyContext.Set<T>().AddAsync(obj);
            await _companyContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _companyContext.Set<T>().Remove(entity);
            await _companyContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _companyContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _companyContext.Set<T>().FindAsync(id);
        }

        public async Task Update(int id, T obj)
        {
            _companyContext.Set<T>().Update(obj);
            await _companyContext.SaveChangesAsync();
        }
    }
}
