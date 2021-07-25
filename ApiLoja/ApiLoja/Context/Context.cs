using ApiLoja.Models;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;




namespace ApiLoja
{
    public class Context : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public Context(DbContextOptions<Context> options) :
            base(options)
        {
         
        }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
