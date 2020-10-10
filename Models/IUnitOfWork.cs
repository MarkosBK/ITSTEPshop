using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_SHOP.Models
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Good> Goods { get; }
        IRepository<Category> Categories { get; }
        void Save();
    }
}
