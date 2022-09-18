using InterviewDemo.Abstractions;
using InterviewDemo.Enums;

namespace InterviewDemo.DTO
{
    public class AddressDTO: EntityBaseDTO, IAddressDTO
    {
        public string AddressLine1 { get; set; } = string.Empty;
        public string? AddressLine2 { get; set; }
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public States State { get; set; }
    }
}
