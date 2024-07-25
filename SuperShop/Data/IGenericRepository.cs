using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();         //Read

        Task<T> GetByIdAsync(int id);   //Read por id


        Task CreateAsync(T entity);    //Create
                                       

        Task UpdateAsync(T entity);  //Update


        Task DeleteAsync(T entity);    //Delete


        Task<bool> ExistAsync(int id);

    }
}
