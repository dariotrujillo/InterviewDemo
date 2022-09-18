using InterviewDemo.Abstractions;

namespace InterviewDemo.Model
{
    public class Warehouse : EntityBase, IWarehouse
    {
        public string Name { get; set; } = string.Empty;
        public int? LocationId { get; set; }
        public Address? Location { get; set; } = new Address();
    }
}
