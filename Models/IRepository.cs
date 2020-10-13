using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_SHOP.Models
{
    public interface IRepository<T> : IDisposable where T : IEntity
    {
        IEnumerable<T> GetList();
        T GetById(int id);
        void Delete(int id);
        void Update(T entity);
        void Create(T entity);
    }

    public interface IEntity
    {
        int Id { get; set; }
    }
}
