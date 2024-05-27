using apiProject.DataAccessLayer.concrete;
using apiProject.EntityLayer.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiProject.BusinessLayer.concrete
{
    public class toDoListManager : IToDoListService
    {
        IToDoListDal _toDoList;

        public toDoListManager(IToDoListDal toDoList)
        {
            _toDoList = toDoList;
        }

        public void delete(toDoList p)
        {
            _toDoList.delete(p);
            
        }

        public List<toDoList> GetAll()
        {
            return _toDoList.GetAll();
        }

        public toDoList getById(int id)
        {
            return _toDoList.getById(id);
        }

        public void insert(toDoList p)
        {
            _toDoList.insert(p);
        }

        public void update(toDoList p)
        {
            _toDoList.update(p);
        }
    }
}
