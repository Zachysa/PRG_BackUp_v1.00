using PRG_BackUp_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRG_BackUp_v1._0.DatabaseRepository
{
    public class BackUpConfigRepositary
    {
        private MyContext db = new MyContext();

        public List<BackUpConfig> WritteAll()
        {
            return this.db.tbBackupConfig.ToList();
        }

        public BackUpConfig FindById(int id)
        {
            return this.db.tbBackupConfig.Find(id);
        }

        public BackUpConfig Add(BackUpConfig backupconfig)
        {

            this.db.tbBackupConfig.Add(backupconfig);
            this.db.SaveChanges();
            return backupconfig;
        }

        public BackUpConfig Update(BackUpConfig backupconfig)
        {
            this.db.Entry(backupconfig).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.db.SaveChanges();
            return backupconfig;
        }

        public void Remove(BackUpConfig backupconfig)
        {
            this.db.tbBackupConfig.Remove(backupconfig);
            this.db.SaveChanges();
        }
    }
}
