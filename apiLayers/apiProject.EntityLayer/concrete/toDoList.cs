using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiProject.EntityLayer.context
{
    public class toDoList
    {

        public int toDoListId { get; set; }
        public string toDoListHeader { get; set; }
        public string toDoListDescription { get; set; }
        public string toDoListImage { get; set; }
    }
}
