using PRG_BackUp_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRG_BackUp_v1._0.DatabaseRepository
{
    public class TimeRepositary
    {
        private MyContext db = new MyContext();

        public List<Time> WritteAll()
        {
            return this.db.tbTime.ToList();
        }

        public List<Time> FindByConfig(int id)
        {
            return this.db.tbTime.Where(x => x.IdConfig == id).ToList();
        }

        public Time FindById(int id)
        {
            return this.db.tbTime.Find(id);
        }

        public Time Add(Time time)
        {
            this.db.tbTime.Add(time);
            this.db.SaveChanges();
            return time;
        }

        public Time Update(Time time)
        {
            this.db.Entry(time).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.db.SaveChanges();
            return time;
        }

        public void Remove(Time time)
        {
            this.db.tbTime.Remove(time);
            this.db.SaveChanges();
        }
    }
}
