using apiProject.EntityLayer.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiProject.DataAccessLayer.concrete
{
    public interface IToDoListService
    {
        void insert(toDoList p);
        void delete(toDoList p);
        void update(toDoList p);
        List<toDoList> GetAll();
        toDoList getById(int id);
    }
}
