using Application.Common.Interfaces;
using Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    public class Repository<T> : IRepository<T> where T : class, IDisposable
    {
        private readonly IApplicationDbContext _context;
        public Repository(IApplicationDbContext context)
        {
            this._context = context;
        }

        public bool Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T Update(int id, T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return Get(id);
        }

        public void Dispose()
        {
        }

    }
}