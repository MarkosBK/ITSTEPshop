using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class CategoryRepository : IRepository<Category>, IDisposable
    {
        public ShopContext db { get; set; }
        public CategoryRepository(ShopContext context)
        {
            db = context;
        }
        public void Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Categories.Remove(GetById(id));
            db.SaveChanges();
        }

        public Category GetById(int id)
        {
            return db.Categories.FirstOrDefault(g => g.Id == id);
        }

        public IEnumerable<Category> GetList()
        {
            return db.Categories.ToList();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

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