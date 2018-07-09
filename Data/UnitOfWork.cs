using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace deleohynekwedding.Data
{
    public class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        private readonly IServiceProvider _serviceCollection;
        private TContext _context;

        public UnitOfWork(IServiceProvider serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if (_context == null) _context = _serviceCollection.GetService<TContext>();
            return new Repository<T>(_context);
        }
    }

    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : class;
    }
}
