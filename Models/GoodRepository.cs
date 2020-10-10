using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class GoodRepository : IRepository<Good>, IDisposable
    {
        public ShopContext db;
        public GoodRepository(ShopContext context)
        {
            db = context;
        }
        public void Create(Good good)
        {
            db.Goods.Add(good);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Goods.Remove(GetById(id));
            db.SaveChanges();
        }

        public Good GetById(int id)
        {
            return db.Goods.First(g => g.Id == id);
        }

        public IEnumerable<Good> GetList()
        {
            return db.Goods.ToList();
        }

        public void Update(Good good)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}