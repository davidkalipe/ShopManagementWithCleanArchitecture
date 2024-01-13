namespace Application.CustomServices;

public interface IClientService<T>
{
    List<T> GetAllClient();
    void FindById(string id);
    void Add(T entity);
    Task<T> Update(T entity);
    void Delete(T entity);

}