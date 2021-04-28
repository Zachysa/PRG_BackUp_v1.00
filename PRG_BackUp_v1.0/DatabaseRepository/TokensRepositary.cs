using PRG_BackUp_v1._0.Models;
using System;
using System.Linq;

namespace PRG_BackUp_v1._0.DatabaseRepository
{
    public class TokensRepositary
    {
        private MyContext db = new MyContext();

        public Token FindByValue(string value)
        {
            return this.db.tbtoken.Where(x => x.Value == value).FirstOrDefault();
        }

        public void Insert(Token token)
        {
            this.db.tbtoken.Add(token);
            this.db.SaveChanges();
        }

        public void Remove(Token token)
        {
            this.db.tbtoken.Remove(token);
            this.db.SaveChanges();
        }

        public void CleanExpired()
        {
            IQueryable<Token> tokens = this.db.tbtoken.Where(x => x.ValidUntil < DateTime.Now);
            this.db.tbtoken.RemoveRange(tokens);
            this.db.SaveChanges();
        }
    }
}
