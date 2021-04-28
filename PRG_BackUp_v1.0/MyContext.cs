using Microsoft.EntityFrameworkCore;
using PRG_BackUp_v1._0.Models;

namespace PRG_BackUp_v1._0
{
    public class MyContext : DbContext
    {
        public DbSet<Backup> tbBackup { get; set; }
        public DbSet<BackUpConfig> tbBackupConfig { get; set; }
        public DbSet<File> tbFile { get; set; }
        public DbSet<Pc> tbPc { get; set; }
        public DbSet<PcBackUp> tbBackupPc { get; set; }
        public DbSet<Storage> tbStorage { get; set; }
        public DbSet<Time> tbTime { get; set; }
        public DbSet<User> tbUser { get; set; }
        public DbSet<Token> tbtoken { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=ftp.pilnyjakub.eu;database=zacharfilip;user=zacharfilip;password=123456");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
