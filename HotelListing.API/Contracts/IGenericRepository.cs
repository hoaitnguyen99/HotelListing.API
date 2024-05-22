namespace HotelListing.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        //Create
        Task<T> AddAsync(T entity);
        Task<List<T>> GetAllAsync();
        //Read
        Task<T> GetAsync(int? id);
        //Update
        Task UpdateAsync(T entity);
        //Delete
        Task DeleteAsync(int? id);
        Task<bool> Exist(int? id);
    }
}
