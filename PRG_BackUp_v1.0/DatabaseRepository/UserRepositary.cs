using PRG_BackUp_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRG_BackUp_v1._0.DatabaseRepository
{
    public class UserRepositary
    {
        private MyContext db = new MyContext();

        public List<User> WritteAll()
        {
            return this.db.tbUser.ToList();
        }

        public User FindById(int id)
        {
            return this.db.tbUser.Find(id);
        }
        public User FindByUsername(string username)
        {
            return this.db.tbUser.Where(x => x.Username == username).FirstOrDefault();
            
        }

        public User Add(User user)
        {
            this.db.tbUser.Add(user);
            this.db.SaveChanges();
            return user;
        }

        public User Update(User user)
        {
            this.db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.db.SaveChanges();
            return user;
        }

        public void Remove(User user)
        {
            this.db.tbUser.Remove(user);
            this.db.SaveChanges();
        }
    }
}
