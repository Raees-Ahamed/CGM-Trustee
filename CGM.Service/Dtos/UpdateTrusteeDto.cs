using CGM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGM.Service.Dtos
{
    public class UpdateTrusteeDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public int ContactNumber { get; set; }
        public Trustee UpdateTrustee(UpdateTrusteeDto addTrusteeDto)
        {
            return new Trustee
            {
                Id = addTrusteeDto.Id.ToString(),
                Name = addTrusteeDto.Name,
                AddressLine1 = addTrusteeDto.AddressLine1,
                AddressLine2 = addTrusteeDto.AddressLine2,
                AddressLine3 = addTrusteeDto.AddressLine3,
                ContactNumber = addTrusteeDto.ContactNumber
            };
        }
    }
}
