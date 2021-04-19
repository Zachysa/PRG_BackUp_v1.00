using PRG_BackUp_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRG_BackUp_v1._0.DatabaseRepository
{
    public class StorageRepositary
    {
        private MyContext db = new MyContext();

        public List<Storage> WritteAll()
        {
            return this.db.tbStorage.ToList();
        }

        public List<Storage> FindByConfig(int id)
        {
            return this.db.tbStorage.Where(x => x.IdConfig == id).ToList();
        }

        public Storage FindById(int id)
        {
            return this.db.tbStorage.Find(id);
        }

        public Storage Add(Storage storage)
        {
            this.db.tbStorage.Add(storage);
            this.db.SaveChanges();
            return storage;
        }

        public Storage Update(Storage storage)
        {
            this.db.Entry(storage).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.db.SaveChanges();
            return storage;
        }

        public void Remove(Storage storage)
        {
            this.db.tbStorage.Remove(storage);
            this.db.SaveChanges();
        }
    }
}
