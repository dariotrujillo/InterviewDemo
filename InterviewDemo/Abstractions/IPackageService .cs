namespace InterviewDemo.Abstractions
{
    public interface IPackageService<T>: IBaseGenericService<T>
    {
        Task<ICollection<T>> GetAllFromWarehouse(int id);
    }
}
