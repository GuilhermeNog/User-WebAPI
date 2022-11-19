using Microsoft.EntityFrameworkCore;
using WebAPIWorkSearch.Modal;

namespace WebAPIWorkSearch.Data
{
    public class WorkSearchContext : DbContext
    {
        public WorkSearchContext(DbContextOptions<WorkSearchContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
