using apiProject.EntityLayer.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiProject.DataAccessLayer.concrete
{
    public class context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= Fatih\\SQLEXPRESS; initial catalog=apiDataBase; integrated security=true; TrustServerCertificate=True;");
        }
        public DbSet<toDoList> toDoLists { get; set; }
    }
}
