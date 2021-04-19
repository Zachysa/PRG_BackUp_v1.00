using PRG_BackUp_v1._0.Models;
using System.Collections.Generic;
using System.Linq;

namespace PRG_BackUp_v1._0.DatabaseRepository
{
    public class FileRepository
    {
        private MyContext db = new MyContext();

        public List<File> FindAll()
        {
            return this.db.tbFile.ToList();
        }

        public List<File> FindByConfig(int id)
        {
            return this.db.tbFile.Where(x => x.IdConfig == id).ToList();
        }

        public File FindById(int id)
        {
            return this.db.tbFile.Find(id);
        }

        public File Add(File file)
        {
            this.db.tbFile.Add(file);
            this.db.SaveChanges();
            return file;
        }

        public File Update(File file)
        {
            this.db.Entry(file).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.db.SaveChanges();
            return file;
        }

        public void Remove(File file)
        {
            this.db.tbFile.Remove(file);
            this.db.SaveChanges();
        }
    }
}
