using CGM.Service.Dtos;
using CGM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGM.Service.Interfaces
{
    public interface ITrusteeService
    {
        public Task<Trustee> AddTrustee(AddTrusteeDto trusteeDto);
        public Task<Trustee> UpdateTrustee(AddTrusteeDto trusteeDto);
        public Task<IEnumerable<Trustee>> GetAllTrustee();
        public Task<Trustee> FindTrusteeById(Guid id);
        public Task<Trustee> RemoveTrusteeById(Guid id);
    }
}
