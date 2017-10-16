using System.Collections.Generic;
using System.Linq;

namespace UsersApp.DAL
{
    public class UsersAppDao : IUsersAppDao
    {
        public User GetUserById(int id)
        {
            User user = null;
            using (var db = new UsersAppContext())
            {
                 user = db.Users.FirstOrDefault(x => x.Id == id);
            }

            return user;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = null;
            using (var db = new UsersAppContext())
            {
                users = db.Users.ToList();
            }

            return users;
        }

        public void UpdateUserById(User user, int id)
        {
            using (var db = new UsersAppContext())
            {
                var foundUser = db.Users.FirstOrDefault(x => x.Id == id);
                foundUser = user;
                db.SaveChanges();
            }
        }

        public void RemoveUserById(int id)
        {
            using (var db = new UsersAppContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Id == id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
            }
        }

        public void AddUser(User user)
        {
            using (var db = new UsersAppContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public List<User> GetSpecifiedUsers(int skip, int take)
        {
            List<User> usersResponse = null; 
            using (var db = new UsersAppContext())
            {
                usersResponse = db.Users.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
            }

            return usersResponse;
        }

        public int GetUsersAmount()
        {
            int amount;
            using (var db = new UsersAppContext())
            {
                amount = db.Users.Count();
            }

            return amount;
        }
    }
}