using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiProject.DataAccessLayer.concrete.repostories
{
    public class genericRepository<T> : IRepository<T> where T : class
    {
        private readonly context _context;

        public genericRepository(context context)
        {
            _context = context;
        }

        public void delete(T p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T getById(int id)
        {
            return _context.Set<T>().Find(id);    
        }

        public void insert(T p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void update(T p)
        {
            _context.Update(p);
            _context.SaveChanges();
        }
    }
}
