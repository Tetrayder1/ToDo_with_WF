using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Todos_table> Todos=>Set<Todos_table>();
        public DbSet<Vision_table> Vision=>Set<Vision_table>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=ASUS\\SQLEXPRESS;Database=ToDo;User ID=sa;Password=1;TrustServerCertificate=True;");
    }
}
