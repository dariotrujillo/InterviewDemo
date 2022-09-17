using InterviewDemo.Abstractions;

namespace InterviewDemo.Model
{
    public sealed class Warehouse : EntityBase, IWarehouse
    {
        public string Name { get; set; } = string.Empty;
        public int? LocationId { get; set; }
        public Address Location { get; set; } = new Address();
        public ICollection<Package> Packages { get; set; } = new List<Package>();
    }
}
