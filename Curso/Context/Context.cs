using Curso.Models;
using Microsoft.EntityFrameworkCore;

namespace Curso.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
