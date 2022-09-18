using InterviewDemo.Abstractions;

namespace InterviewDemo.Model
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
    }
}
