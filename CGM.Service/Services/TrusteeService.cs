
using CGM.Data.Entities;
using CGM.Data.Interfaces;
using CGM.Service.Dtos;
using CGM.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGM.Service.Services
{
    public class TrusteeService : ITrusteeService
    {
        private readonly ITrusteeRepsoitory trusteeRepsoitory;

        public TrusteeService(ITrusteeRepsoitory _trusteeRepsoitory)
        {
            trusteeRepsoitory = _trusteeRepsoitory;
        }
        public Task<Trustee> AddTrustee(AddTrusteeDto trusteeDto)
        {
            return trusteeRepsoitory.AddTrustee(trusteeDto.NewTrustee(trusteeDto));
        }

        public Task<Trustee> FindTrusteeById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Trustee>> GetAllTrustee()
        {
            return await trusteeRepsoitory.GetAllTrustee();
        }

        public Task<Trustee> RemoveTrusteeById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Trustee> UpdateTrustee(AddTrusteeDto trusteeDto)
        {
            throw new NotImplementedException();
        }
    }
}
