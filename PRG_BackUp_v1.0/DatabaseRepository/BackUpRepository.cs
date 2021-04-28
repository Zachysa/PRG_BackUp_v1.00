using PRG_BackUp_v1._0.Models;
using System.Collections.Generic;
using System.Linq;

namespace PRG_BackUp_v1._0.DatabaseRepository
{
    public class BackUpRepository
    {
        private MyContext db = new MyContext();

        public List<Backup> FindAll()
        {
            return this.db.tbBackup.ToList();
        }

        public List<Backup> FindByPcBackup(int id)
        {
            return this.db.tbBackup.Where(x => x.IdPcBackUp == id).ToList();
        }

        public Backup FindById(int id)
        {
            return this.db.tbBackup.Find(id);
        }

        public Backup Add(Backup backup)
        {
            this.db.tbBackup.Add(backup);
            this.db.SaveChanges();
            return backup;
        }

        public Backup Update(Backup backup)
        {
            this.db.Entry(backup).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.db.SaveChanges();
            return backup;
        }

        public void Remove(Backup pc)
        {
            this.db.tbBackup.Remove(pc);
            this.db.SaveChanges();
        }
    }
}
