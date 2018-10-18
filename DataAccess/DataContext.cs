using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        // public DbSet<Bookscs> Books{get; set;}
        public DbSet<books> Books {get;set;}

    }
}