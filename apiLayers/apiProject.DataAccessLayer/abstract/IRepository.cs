using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiProject.DataAccessLayer.concrete
{
    public interface IRepository<T>where T : class
    {
        void insert (T p);
        void delete (T p);
        void update (T p);
        List<T> GetAll ();
        T getById (int id);
    }
}
