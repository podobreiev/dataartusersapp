using System.Data.Entity;

namespace UsersApp.DAL
{
    public class UsersAppContext : DbContext
    {
        public UsersAppContext() : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}