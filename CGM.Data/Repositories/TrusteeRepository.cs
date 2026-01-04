using CGM.Data.DatabaseContext;
using CGM.Data.Entities;
using CGM.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGM.Data.Repositories
{
    public class TrusteeRepository : ITrusteeRepsoitory
    {
        private readonly ApplicationDbContext context;

        public TrusteeRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<Trustee> AddTrustee(Trustee trustee)
        {
            var isAdded = context.Trustees.AddAsync(trustee);
            await context.SaveChangesAsync();
            return trustee;
        }

        public async Task<IEnumerable<Trustee>> GetAllTrustee()
        {
            var AllTrustees = context.Trustees.AsEnumerable();
            return AllTrustees;
        }

        public Task<Trustee> GetTrusteeById(int id)
        {
            var trustee = context.Trustees.Find(id);
            return Task.FromResult(trustee);
        }

        public Task<Trustee> UpdateTrustee(Trustee trustee)
        {
            var isUpdated = context.Trustees.Update(trustee);
            return Task.FromResult(isUpdated.Entity);
        }
    }
}
