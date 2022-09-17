namespace InterviewDemo.Abstractions
{
    public interface IBaseGenericRepository<U>
    {
        Task<ICollection<U>> GetAll();
        Task<U?> Get(int id);
        Task<int> Add(U entityDTO);
        Task<int> Update(U entityDTO);
        Task<int> Delete(U entityDTO);
    }
}
