using apiProject.DataAccessLayer.concrete;
using apiProject.DataAccessLayer.concrete.repostories;
using apiProject.EntityLayer.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiProject.DataAccessLayer.EntityFramework
{
    public class EfToDoListDal : genericRepository<toDoList>, IToDoListDal
    {
        public EfToDoListDal(context context) : base(context)
        {
        }
    }
}
