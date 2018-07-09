using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace deleohynekwedding.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Add(item);
        }

        public ICollection<T> Find(Predicate<T> predicate)
        {
            return _context.Set<T>().Where(x => predicate(x)).ToList();
        }

        public T Get(int id)
        {
            return _context.Find<T>(id);
        }

        public ICollection<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Remove(int id)
        {
            _context.Remove(this.Get(id));
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Update(item);
        }
    }

    public interface IRepository<T>
    {
        void Add(T item);
        ICollection<T> GetAll();
        T Get(int id);
        ICollection<T> Find(Predicate<T> predicate);
        void Remove(int id);
        void Update(T item);
        void SaveChanges();
    }
}
