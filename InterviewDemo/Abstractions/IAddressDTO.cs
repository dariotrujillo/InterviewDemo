using InterviewDemo.Enums;
using InterviewDemo.Model;

namespace InterviewDemo.Abstractions
{
    public interface IAddressDTO
    {
        string AddressLine1 { get; set; }
        string? AddressLine2 { get; set; }
        string City { get; set; }
        string ZipCode { get; set; }
        States State { get; set; }
    }
}
