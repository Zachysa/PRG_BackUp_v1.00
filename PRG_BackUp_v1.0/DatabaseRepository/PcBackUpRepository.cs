using PRG_BackUp_v1._0.Models;
using System.Collections.Generic;
using System.Linq;

namespace PRG_BackUp_v1._0.DatabaseRepository
{
    public class PcBackUpRepository
    {
        private MyContext db = new MyContext();

        public List<PcBackUp> WritteAll()
        {
            return this.db.tbBackupPc.ToList();
        }

        public List<PcBackUp> FindByPc(int id)
        {
            return this.db.tbBackupPc.Where(x => x.IdPc == id).ToList();
        }

        public PcBackUp FindByPcAndConfig(int idPc, int idConfig)
        {
            return this.db.tbBackupPc.Where(x => x.IdPc == idPc).Where(y => y.IdConfig == idConfig).FirstOrDefault();
        }

        public PcBackUp FindById(int id)
        {
            return this.db.tbBackupPc.Find(id);
        }

        public PcBackUp Add(PcBackUp pcbackup)
        {
            this.db.tbBackupPc.Add(pcbackup);
            this.db.SaveChanges();
            return pcbackup;
        }

        public PcBackUp Update(PcBackUp pcbackup)
        {
            this.db.Entry(pcbackup).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.db.SaveChanges();
            return pcbackup;
        }

        public void Remove(PcBackUp pcbackup)
        {
            this.db.tbBackupPc.Remove(pcbackup);
            this.db.SaveChanges();
        }
    }
}
