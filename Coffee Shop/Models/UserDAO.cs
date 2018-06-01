using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Coffee_Shop.Models
{
    public class UserDAO : IDAO
    {
        private CoffeeShopDBEntities db;

        public UserDAO()
        {
            db = new CoffeeShopDBEntities();
        }

        public User GetUser (int id)
        {
            return db.Users.Find(id);
        }

        public List<User> GetUserList()
        {
            return db.Users.ToList();
        }

        public void AddUser (User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void DeleteUser(int id)
        {

        }

        public void EditUser (User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Dispose ()
        {
            db.Dispose();
        }
    }


}