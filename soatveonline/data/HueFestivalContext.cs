
using Microsoft.EntityFrameworkCore;
using soatveonline.Model;

namespace soatveonline.Data
{
    public class HueFestivalContext : DbContext
    {
        public HueFestivalContext(DbContextOptions<HueFestivalContext> options)
            : base(options)
        {
        }

        public DbSet<location> Locations { get; set; }
        
        public DbSet<news> News { get; set; }
        
        public DbSet<programs> Programmes { get; set; }
       
        
        public DbSet<tickets> Tickets { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<HelpMenu> HelpMenus { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
