using InterviewDemo.Abstractions;

namespace InterviewDemo.DTO
{
    public class EntityBaseDTO: IEntityBaseDTO
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
    }
}
