using EDDPlus.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace EDDPlus.DB
{
    public class eddplus : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlite($"Data Source=eddplus.db");

            base.OnConfiguring(ob);
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
        }

        public DbSet<User> Users { get; set; }
    }
}
