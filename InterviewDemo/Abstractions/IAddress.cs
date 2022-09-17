using InterviewDemo.Enums;

namespace InterviewDemo.Abstractions
{
    public interface IAddress
    {
        string AddressLine1 { get; set; }
        string? AddressLine2 { get; set; }
        string City { get; set; }
        string ZipCode { get; set; }
        States State { get; set; }
    }
}
