using PRG_BackUp_v1._0.Models;
using System.Collections.Generic;
using System.Linq;

namespace PRG_BackUp_v1._0
{
    public class PcRepositary
    {
        private MyContext db = new MyContext();

        public List<Pc> WritteAll()
        {
            return this.db.tbPc.ToList();
        }

        public Pc FindById(int id)
        {
            return this.db.tbPc.Find(id);
        }

        public Pc Add(Pc pc)
        {
            this.db.tbPc.Add(pc);
            this.db.SaveChanges();
            return pc;
        }

        public Pc Update(Pc pc)
        {
            this.db.Entry(pc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.db.SaveChanges();
            return pc;
        }

        public void Remove(Pc pc)
        {
            this.db.tbPc.Remove(pc);
            this.db.SaveChanges();
        }
    }
}
