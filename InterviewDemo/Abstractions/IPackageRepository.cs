namespace InterviewDemo.Abstractions
{
    public interface IPackageRepository<U> : IBaseGenericRepository<U>
    {
        Task<ICollection<U>> GetAllFromWarehouse(int id);
    }
}
