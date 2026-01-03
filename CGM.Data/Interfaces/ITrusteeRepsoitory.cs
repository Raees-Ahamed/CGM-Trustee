using CGM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGM.Data.Interfaces
{
    public interface ITrusteeRepsoitory
    {
        public Task<Trustee> GetTrusteeById(int id);
        public Task<IEnumerable<Trustee>> GetAllTrustee();
        public Task<Trustee> AddTrustee(Trustee trustee);
        public Task<Trustee> UpdateTrustee(Trustee trustee);
    }
}
