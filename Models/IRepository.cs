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
        //IEnumerable<T> GetList(string include);
        T GetById(int id);
        void Delete(int id);
        //void Delete(T entity);
        void Update(T entity);
        void Create(T entity);
        //void Save();
    }

    public interface IEntity
    {
        int Id { get; set; }
    }
}
