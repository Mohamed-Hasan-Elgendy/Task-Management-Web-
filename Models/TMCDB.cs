using Microsoft.EntityFrameworkCore;

namespace TMC.Models
{
    public class TMCDB:DbContext
    {
        public DbSet<mytasks> Mytasks { get; set; }
        public DbSet<myprojects> Myprojects { get; set; }
        public DbSet<myteammember> Myteammembers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TMCDB;Persist Security Info=True;User ID=sa;Password=FIATS@2024;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
