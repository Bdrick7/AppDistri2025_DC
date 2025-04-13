using Microsoft.EntityFrameworkCore;
using WebApiPerson_DC.Models;

namespace WebApiPerson_DC.Context
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base (options) { 
        }

        public DbSet<Person> Persons { get; set; }
    }
}
