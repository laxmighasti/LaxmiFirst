using Microsoft.EntityFrameworkCore;

namespace EntityDbContext
{
    public class EFCoreContext : DbContext
    {
        public EFCoreContext(DbContextOptions<EFCoreContext> options)
            : base(options)
         {

         }
        public DbSet<Employee> EMPLOYEE { get; set; }
        
    }
}