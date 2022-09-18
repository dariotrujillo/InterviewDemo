using InterviewDemo.Model;

namespace InterviewDemo.Abstractions
{
    public interface IWarehouse
    {
        string Name { get; set; }
        int? LocationId { get; set; }
        Address? Location { get; set; }
    }
}
