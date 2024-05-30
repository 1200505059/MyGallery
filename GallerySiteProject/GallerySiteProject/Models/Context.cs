using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace GallerySiteProject.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer("server=DESKTOP-0KSRB41\\SQLEXPRESS;database=GaleriSite;integrated security=true;");
        }
        public DbSet<TblGiris> tblGirises { get; set; }
        public DbSet<TblHakkimda> tblHakkimdas { get; set;}
        public DbSet<TblResimler> tblResimlers { get; set;}
        public DbSet<TblAdmin> tblAdmins { get; set;}
    }
}
