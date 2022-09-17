namespace InterviewDemo.Abstractions
{
    public interface IBaseGenericService<T>
    {
        Task<ICollection<T>> GetAll();
        Task<T?> Get(int id);
        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
