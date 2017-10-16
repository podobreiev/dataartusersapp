using System;
using System.Data.Entity;

namespace UsersApp.DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<UsersAppContext>
    {
        protected override void Seed(UsersAppContext context)
        {
            for (int i = 0; i < 25; i++)
            {
                User user = new User()
                {
                    Birthday = DateTime.Now,
                    Department = "Department" + i,
                    FirstName = "FirstName" + i,
                    Id = i + 1,
                    Job = "Job" + i,
                    ImagePath = "../Images/Users/unnamed.png",
                    LastName = "LastName" + i,
                    PrivatePhone = "PrivatePhone" + i,
                    UserInfo = "UserInfo" + i,
                    WorkPhone = "WorkPhone" + i
                };  
                
                context.Users.Add(user);
                context.SaveChanges();
            }

        }
    }
}