namespace AspNetPipelines.Api.DataAccess
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll<T>();
        Task Add<T>(T t);
    }
}
