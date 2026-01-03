using CGM.Data.Entities;

namespace CGM.Service.Dtos
{
    public class AddTrusteeDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public int ContactNumber { get; set; }


        public Trustee NewTrustee(AddTrusteeDto addTrusteeDto)
        {
            return new Trustee
            {
                Id = Guid.NewGuid(),
                Name = addTrusteeDto.Name,
                AddressLine1 = addTrusteeDto.AddressLine1,
                AddressLine2 = addTrusteeDto.AddressLine2,
                AddressLine3 = addTrusteeDto.AddressLine3,
                ContactNumber = addTrusteeDto.ContactNumber
            };
        }

        public Trustee UpdateTrustee(AddTrusteeDto addTrusteeDto)
        {
            return new Trustee
            {
                Id = addTrusteeDto.Id,
                Name = addTrusteeDto.Name,
                AddressLine1 = addTrusteeDto.AddressLine1,
                AddressLine2 = addTrusteeDto.AddressLine2,
                AddressLine3 = addTrusteeDto.AddressLine3,
                ContactNumber = addTrusteeDto.ContactNumber
            };
        }
    }   
}
